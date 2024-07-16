using AutoMapper;
using Azure;
using Microsoft.EntityFrameworkCore;
using NhaDat24h.Common.Enums;
using SmartBot.Common.Extention;
using SmartBot.Common.Helpers;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.User;
using System.Data;
using System.IdentityModel.Tokens.Jwt;

namespace SmartBot.Services.Users
{
    public class UserService : IUserService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<ClientCustomer> _clientCustomerRepository;
        private readonly ICommonRepository<User> _userRepository;
        private readonly ICommonRepository<UserClient> _userClientRepository;
        private readonly ICommonRepository<UsersAccountFb> _userAccountRepository;


        public UserService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<User> userRepository, ICommonRepository<ClientCustomer> clientCustomerRepository,
            ICommonRepository<UserClient> userClientRepository, ICommonRepository<UsersAccountFb> userAccountRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _userRepository = userRepository;
            _clientCustomerRepository = clientCustomerRepository;
            _userClientRepository = userClientRepository;
            _userAccountRepository = userAccountRepository;
        }
        public ResponseBase CheckUserByAccount(string userName, string password, string hardwareId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var user = _userRepository.FindAll(x => x.UserName == userName).SingleOrDefault();
                if (user == null)
                {
                    return new ResponseBase()
                    {
                        Code = 99,
                        Message = StatusLogin.UserNotExisting.ToString(),
                        Data = new LoginDto()
                        {
                            Status = (int)StatusLogin.UserNotExisting,
                            Token = "",
                            IdUser = 0
                        },

                    };
                }
                else
                {
                    if (user.Password != password)
                    {
                        return new ResponseBase()
                        {
                            Code = 98,
                            Message = StatusLogin.PasswordWrong.ToString(),
                            Data = new LoginDto()
                            {
                                Status = (int)StatusLogin.PasswordWrong,
                                Token = "",
                                IdUser = 0
                            },

                        };
                    }
                    if (user.Status == 0)
                    {
                        return new ResponseBase()
                        {
                            Code = 97,
                            Message = "Tài khoản chưa được kích hoạt, vui lòng nhập license",
                            Data = new LoginDto()
                            {
                                Status = (int)StatusLogin.NoLicense,
                                Token = "",
                                IdUser = user.Id
                            }

                        };
                    }
                    if (user.ExpiryDate < DateTime.Now)
                    {
                        return new ResponseBase()
                        {
                            Code = 96,
                            Message = "Tài khoản đã hết hạn dùng",
                            Data = new LoginDto()
                            {
                                Status = (int)StatusLogin.LicenseExpires,
                                Token = "",
                                IdUser = user.Id
                            }

                        };
                    }
                }
                var idClient = 0;
                var client = _clientCustomerRepository.FindAll(x => x.HardwareId == hardwareId).FirstOrDefault();
                if (client == null)
                {
                    var newClient = new ClientCustomer()
                    {
                        HardwareId = hardwareId,
                        DateUpdate = DateTime.Now,
                    };
                    _commonUoW.BeginTransaction();
                    _clientCustomerRepository.Insert(newClient);
                    _commonUoW.Commit();
                    idClient = newClient.Id;
                }
                else
                {
                    idClient = client.Id;
                }
                var userclient = _userClientRepository.FindAll(x => x.IdUser == user.Id && x.IdClient == idClient).FirstOrDefault();
                string token = "";
                if (userclient == null)
                {
                    var newuserclient = new UserClient()
                    {
                        IdUser = user.Id,
                        IdClient = idClient,
                        DateUpdate = DateTime.Now,
                        Status = 1,
                        Token = Token.GenerateSecurityToken(user.Id, "7"),
                    };
                    token = newuserclient.Token;
                    _commonUoW.BeginTransaction();
                    _userClientRepository.Insert(newuserclient);
                    _commonUoW.Commit();
                }
                else
                {
                    userclient.DateUpdate = DateTime.Now;
                    userclient.Token = Token.GenerateSecurityToken(user.Id, "7");

                    _commonUoW.BeginTransaction();
                    _userClientRepository.Update(userclient);
                    _commonUoW.Commit();
                    token = userclient.Token;

                }

                return new ResponseBase()
                {
                    Code = 0,
                    Message = "Success",
                    Data = new LoginDto()
                    {
                        Status = (int)StatusLogin.Success,
                        Token = token,
                        IdUser = user.Id,
                    },

                };
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
        public ResponseBase CheckUserByToken(string token, string hwId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtSecurityToken = handler.ReadJwtToken(token);

                var userId = int.Parse(jwtSecurityToken.Claims.First(x => x.Type == "nameid").Value);
                var user = _userRepository.GetById(userId);
                if (user == null)
                {
                    response.Code= 2000;
                    response.Message = "User không tồn tại";
                    return response;
                }    
                var client = _clientCustomerRepository.FindAll(x=>x.HardwareId == hwId).SingleOrDefault();
                if (client == null)
                {
                    response.Code= 2001;
                    response.Message = "Client không hợp lệ";
                    return response;
                }
                var userClient = _userClientRepository.FindAll(x=>x.IdClient==client.Id && x.IdUser == userId).SingleOrDefault();
                if (userClient == null)
                {
                    response.Code= 2002;
                    response.Message = "Thiết bị chưa từng được đăng kí, hãy đăng nhập lại";
                    return response;
                }
                if(userClient.Token != token)
                {
                    response.Code= 2003;
                    response.Message = "Token không hợp lệ, hãy đăng nhập lại";
                    return response;
                }    
                return new ResponseBase()
                {
                    Code = 0,
                    Message = "Success",
                    Data = new LoginDto()
                    {
                        Status = (int)StatusLogin.Success,
                        IdUser = user.Id,
                    },
                };
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
        public ResponseBase CheckLicenseUser(string userName, string license)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var user = _userRepository.FindAll(x => x.UserName == userName).FirstOrDefault();
                if (license != user.License)
                {
                    return new ResponseBase()
                    {
                        Code = 99,
                        Message = StatusLogin.NoLicense.GetEnumDescription(),
                        Data = new LoginDto()
                        {
                            Status = (int)StatusLogin.NoLicense,
                            Token = ""
                        },
                    };
                }
                if (user.ExpiryDate < DateTime.Now)
                {
                    return new ResponseBase()
                    {
                        Code = 99,
                        Message = StatusLogin.LicenseExpires.GetEnumDescription(),
                        Data = new LoginDto()
                        {
                            Status = (int)StatusLogin.LicenseExpires,
                            Token = ""
                        },
                    };
                }
                _commonUoW.BeginTransaction();
                user.Status = 1;
                _userRepository.Update(user);
                _commonUoW.Commit();
                return new ResponseBase()
                {
                    Code = 0,
                    Message = "Success",
                    Data = new LoginDto()
                    {
                        Status = (int)StatusLogin.Success,
                        Token = ""
                    },
                };
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
        public ResponseBase GetAccountEverLogin(int idUser)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var listaccount = _userAccountRepository.FindAll(x => x.IdUser == idUser).Include(x => x.IdAccountFbNavigation);
                if (listaccount == null)
                {
                    response.Message = "No account";
                    response.Code = 99;
                    return response;
                }
                else
                {
                    response.Data = listaccount.Select(x => new AccountDto { UserName = x.IdAccountFbNavigation.FbUser, Password = x.IdAccountFbNavigation.FbPassword });
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
        public ResponseBase GetAccountFbEverLogin(int idUser)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var listaccount = _userAccountRepository.FindAll(x => x.IdUser == idUser).Include(x => x.IdAccountFbNavigation);
                if (listaccount == null)
                {
                    response.Message = "No account";
                    response.Code = 99;
                    return response;
                }
                else
                {
                    response.Data = listaccount.Select(x => new AccountFbDto { IdFb = x.IdAccountFbNavigation.Id, UserName = x.IdAccountFbNavigation.FbUser, Password = x.IdAccountFbNavigation.FbPassword });
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }


        public ResponseBase Register(UserDto data)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var olduser = _userRepository.FindAll(x => x.UserName == data.Email);
                if (olduser != null && olduser.Any())
                {
                    response.Message = "username existing";
                    return response;
                }
                var user = new User
                {
                    UserName = data.Email,
                    Password = data.Password,
                    Status = 1,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                };
                _commonUoW.BeginTransaction();
                _userRepository.Insert(user);
                _commonUoW.Commit();

                response.Data = user.Id;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
        public ResponseBase GetUserById(int? idUser)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var temp = _userRepository.FindSingle(x => x.Id==idUser);
                if (temp != null)
                {
                    var newuser = new UserLoginDto()
                    {
                        Id = temp.Id,
                        UserName = temp.UserName,
                        Password = temp.Password,
                        Status = temp.Status,
                        DateCreated = temp.DateCreated,
                        DateUpdate = temp.DateUpdate,
                        ExpiryDate = temp.ExpiryDate,
                        License = temp.License,

                    };
                    response.Data = newuser;
                }
                return response;
            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }

        public ResponseBase GetUser(string userName, string passWord)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var user = _userRepository.FindSingle(x => x.UserName == userName && x.Password == passWord);
                if (user == null) 
                {
                    response.Message = StatusLogin.UserNotExisting.ToString();
                    response.Data = false;
                    response.Code = (int)StatusLogin.UserNotExisting;
                    return response;
                }

                if (!user.Password.Equals(passWord))
                {
                    response.Message = StatusLogin.PasswordWrong.ToString();
                    response.Data = false;
                    response.Code = (int)StatusLogin.PasswordWrong;
                    return response;
                }

                string token = Token.GenerateSecurityToken(user.Id, "7");
                response.Data = token;
                return response;

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }

        public ResponseBase CheckExitUser(string userName)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var getAccUser = _userRepository.FindSingle(x => x.UserName==userName);
                if (getAccUser != null)
                {
                    var newuser = new UserLoginDto()
                    {
                        Id = getAccUser.Id,
                        UserName = getAccUser.UserName,
                    };
                    response.Data = newuser;
                }
                else
                    response.Data=false;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }

        public ResponseBase ChangePassword(ChangePasswordDto passwordDto)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                int IdUser = int.Parse(Token.Authentication(passwordDto.Token));
                User? user = _userRepository.GetById(IdUser);
                if (user == null)
                {
                    response.Data = false;
                    response.Code = 99;
                    response.Message = "Not Found user";
                }
                else if (!user.Password.Equals(passwordDto.CurrentPassword))
                {
                    response.Data = false;
                    response.Code = 99;
                    response.Message = "Old password not correct";
                }
                else if (passwordDto.NewPassword != passwordDto.ConfirmPassword)
                {
                    response.Data = false;
                    response.Code = 99;
                    response.Message = "Confirm password not the same new password";
                }
                else
                {
                    user.Password = passwordDto.ConfirmPassword;
                    user.DateUpdate = DateTime.Now;
                    _commonUoW.BeginTransaction();
                    _userRepository.Update(user);
                    _commonUoW.Commit();
                    response.Data = true;
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Code = 99;
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }

        public ResponseBase ForgotPassword(string userName, string license)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var user = _userRepository.FindSingle(x => x.UserName == userName && x.License == license);
                if (user != null)
                {
                    var newuser = new UserLoginDto()
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Password = user.Password
                    };
                    response.Data = newuser;
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
    }
}
