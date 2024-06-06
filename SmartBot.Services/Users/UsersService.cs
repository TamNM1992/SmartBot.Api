
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using NhaDat24h.Common.Enums;
using SmartBot.Common.Extention;
using SmartBot.Common.Helpers;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.User;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

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
        public ResponseBase CheckUserByToken(string token)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code = 0,
                    Message = "Success",
                    Data = new LoginDto()
                    {
                        Status = (int)StatusLogin.Success,
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
        public User GetById(int idUser)
        {
            var temp = _userRepository.GetById(idUser);
            return temp;
        }
    }

}
