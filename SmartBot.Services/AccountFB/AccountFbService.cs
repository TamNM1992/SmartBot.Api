using AutoMapper;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.AccountFb;
using SmartBot.DataDto.Base;
using User = SmartBot.DataAccess.Entities.User;

namespace SmartBot.Services.AccountFB
{
    public class AccountFbService : IAccountFbService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;

        private readonly ICommonRepository<User> _userRepository;
        private readonly ICommonRepository<UsersAccountFb> _userAccountRepository;
        private readonly ICommonRepository<AccountFb> _accountRepository;
        private readonly ICommonRepository<FanPageFb> _fanpageRepository;

        public AccountFbService(IMapper mapper, ICommonUoW commonUoW,
            ICommonRepository<User> userRepository,
            ICommonRepository<UsersAccountFb> userAccountRepository,
            ICommonRepository<AccountFb> accountRepository, ICommonRepository<FanPageFb> fanpageRepository)
        {
            _mapper=mapper;
            _commonUoW=commonUoW;
            _userRepository=userRepository;
            _userAccountRepository=userAccountRepository;
            _accountRepository=accountRepository;
            _fanpageRepository=fanpageRepository;
        }

        public ResponseBase InsertAccountFb(InsertAccountFbDto param)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var user = _userRepository.GetById(param.idUser);
                if (user==null)
                {
                    response.Message = "User not existing";
                    response.Code = 99;
                    return response;
                }

                var FbAcc = _accountRepository.FindAll(x => x.FbUser==param.FbUser).SingleOrDefault();
                var idfb = 0;
                if (FbAcc==null)
                {
                    var newFb = new AccountFb()
                    {
                        FbUser = param.FbUser,
                        FbPassword = param.FbPassword,
                        FbProfileLink = "",
                        KeySearch  = param.FbUser,
                        DateLogin = DateTime.Now,
                        Status=1,
                    };
                    _commonUoW.BeginTransaction();
                    _accountRepository.Insert(newFb);
                    _commonUoW.Commit();
                    idfb = newFb.Id;
                }
                else
                {
                    idfb = FbAcc.Id;
                }
                var userFb = _userAccountRepository.FindAll(x => x.IdUser==param.idUser&& x.IdAccountFb==idfb).SingleOrDefault();

                if (userFb==null)
                {
                    var newUserFb = new UsersAccountFb()
                    {
                        IdUser = param.idUser,
                        IdAccountFb=idfb,
                        DateUpdate = DateTime.Now,
                        Status = 1,
                    };
                    _commonUoW.BeginTransaction();
                    _userAccountRepository.Insert(newUserFb);
                    _commonUoW.Commit();
                }

                response.Data=idfb;
                return response;

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }

        }
        public ResponseBase GetFaceBookId(string fbUserName)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = _accountRepository.FindAll(x => x.FbUser==fbUserName).FirstOrDefault();
                if (data!=null)
                {
                    response.Data = data.Id;
                }
                else
                {
                    response.Data=0;
                }
                return response;

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }

        }
        public ResponseBase TestChart()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                //TestChartFbDto newchart = new TestChartFbDto();
                //var data = _userAccountRepository.FindAll().GroupBy(u => u.IdUser)
                //.Select(g => new TestChartFbDto()
                // {
                //     //Labels=new string[] { g.Key.ToString() },
                //     //Datas=new int[] { g.Count() },
                //     idUser = g.Key,
                //     CountIdAccountFb=g.Count(),
                // }).ToList();
                //foreach (var item in data)
                //{
                //    newchart.Labels=new string[] { item.idUser.ToString() };
                //    newchart.Datas=new int[] { item.CountIdAccountFb };

                //}
                
                //if (data!=null)
                //{
                //    response.Data = newchart;
                //}
                //else
                //{
                //    response.Data=0;
                //}
                int[] idUser = _userAccountRepository.FindAll().Select(x => x.IdUser).Distinct().ToArray();
                string[] strIdUser = new string[idUser.Length];
                for (int i = 0; i < strIdUser.Length; i++)
                {
                    strIdUser[i] = idUser[i].ToString();
                }
                int[] counts = new int[idUser.Length];
                for (int i = 0; i < idUser.Length; i++)
                {
                    counts[i] = _userAccountRepository.FindAll(u => u.IdUser == idUser[i]).Count();
                }
                TestChartFbDto newchart = new TestChartFbDto();
                newchart.Labels = strIdUser;
                newchart.Datas = counts;
                response.Data = newchart;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
        public ResponseBase CheckMainInfo(string infoName)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = _fanpageRepository.FindAll(x => x.Name==infoName).FirstOrDefault();
                if (data==null)
                {
                    response.Message = "Tài khoản không tồn tại";
                }
                else
                {
                    response.Data= data.MainInfo;
                }
                return response;

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }

        }
    }
}