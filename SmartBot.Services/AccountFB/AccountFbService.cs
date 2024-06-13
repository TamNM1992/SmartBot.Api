using AutoMapper;
using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using Microsoft.Identity.Client;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.AccountFb;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

        public AccountFbService(IMapper mapper, ICommonUoW commonUoW, 
            ICommonRepository<User> userRepository, 
            ICommonRepository<UsersAccountFb> userAccountRepository,
            ICommonRepository<AccountFb> accountRepository)
        {
            _mapper=mapper;
            _commonUoW=commonUoW;
            _userRepository=userRepository;
            _userAccountRepository=userAccountRepository;
            _accountRepository=accountRepository;
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

                var FbAcc= _accountRepository.FindAll(x => x.FbUser==param.FbUser).SingleOrDefault();
                var idfb = 0;
                if(FbAcc==null)
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
                var userFb = _userAccountRepository.FindAll(x=>x.IdUser==param.idUser&& x.IdAccountFb==idfb).SingleOrDefault();
                
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
                var data = _accountRepository.FindAll(x=>x.FbUser==fbUserName).FirstOrDefault();
                if(data!=null)
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
                var data = _userAccountRepository.FindAll().GroupBy(u=>u.IdUser)
                    .Select(g=> new TestChartFbDto()
                    {
                        idUser=g.Key,
                        CountIdAccountFb=g.Count(),
                    }).ToList();
                if (data!=null)
                {
                    response.Data = data;
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
    }
}
