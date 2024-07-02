using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using SmartBot.Common.Enums;
using SmartBot.Common.Helpers;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Action;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Script;
using System.Runtime.CompilerServices;
using static Azure.Core.HttpHeader;
using User = SmartBot.DataAccess.Entities.User;

namespace SmartBot.Services.Action
{
    public class ActionsService : IActionsService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;

        private readonly ICommonRepository<DataAccess.Entities.User> _userRepository;
        private readonly ICommonRepository<UsersAccountFb> _userAccountRepository;
        private readonly ICommonRepository<AccountFb> _accountRepository;
        private readonly ICommonRepository<LogActionScript> _logActionRepository;
        private readonly ICommonRepository<ActionType> _actionTypeRepository;

        public ActionsService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<User> userRepository, ICommonRepository<UsersAccountFb> userAccountRepository, ICommonRepository<AccountFb> accountRepository, ICommonRepository<ActionType> actionTypeRepository, ICommonRepository<LogActionScript> logActionRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _userRepository = userRepository;
            _userAccountRepository = userAccountRepository;
            _accountRepository = accountRepository;
            _logActionRepository=logActionRepository;
            _actionTypeRepository = actionTypeRepository;
        }

        public ResponseBase GetActionHistory(string token, DateTime? start, DateTime? end, int? idFb, int? actionId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var idUser = int.Parse(Token.Authentication(token));
                var logAc = _logActionRepository.FindAll(x => x.IdUser == idUser)
                                                .Include(x => x.IdScriptNavigation)
                                                .Include(x => x.LogStepActions);


                var data = new LogScriptDto
                {
                    ScriptName = logAc.FirstOrDefault().IdScriptNavigation.Name,
                    ListLogAction = logAc.Select(x => new LogActionDto
                    {
                        Id = x.Id,
                        Name = x.Name,
                        StartTime = x.StartTime,
                        EndTime = x.EndTime,
                        IdFb = x.IdFb,
                        NameFb = x.NameFb,
                        Result = x.Result,
                        ListLogStep = x.LogStepActions.Select(x => x.StepDetail).ToList()
                    }).ToList()
                };


                //var data = logActions.Where(log =>
                //           log.IdUser == idUser &&
                //           (!start.HasValue || log.StartTime >= start.Value) &&
                //           (!end.HasValue || log.EndTime <= end.Value) &&
                //           (!idFb.HasValue || log.IdFb == idFb) &&
                //           (!actionId.HasValue || log.Action == actions[(int)actionId])).ToList();

                response.Data = data;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }

        public ResponseBase GetActionType()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = _actionTypeRepository.FindAll();
                response.Data = data;
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
