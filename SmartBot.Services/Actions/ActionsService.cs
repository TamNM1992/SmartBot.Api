using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartBot.Common.Helpers;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Action;
using SmartBot.DataDto.Base;
using System.Globalization;
using System.Linq;

namespace SmartBot.Services.Action
{
    public class ActionsService : IActionsService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<LogActionScript> _logActionRepository;
        private readonly ICommonRepository<ActionType> _actionTypeRepository;
        private readonly ICommonRepository<Script> _scriptRepository;
        private readonly ICommonRepository<LogStepAction> _stepActionRepository;
        private readonly ICommonRepository<LogScript> _logScriptRepository;

        public ActionsService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<ActionType> actionTypeRepository,
            ICommonRepository<LogActionScript> logActionRepository, ICommonRepository<Script> scriptRepository, ICommonRepository<LogStepAction> stepActionRepository, ICommonRepository<LogScript> logScriptRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _logActionRepository = logActionRepository;
            _actionTypeRepository = actionTypeRepository;
            _scriptRepository = scriptRepository;
            _stepActionRepository = stepActionRepository;
            _logScriptRepository = logScriptRepository;
        }

        public ResponseBase GetActionHistory(string token, int currentPage, int itemsPerPage, string? startTime, string? endTime, int? idFb, int? actionId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var idUser = int.Parse(Token.Authentication(token));

                DateTime? start = string.IsNullOrEmpty(startTime) ? null : DateTime.ParseExact(startTime, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime? end = string.IsNullOrEmpty(endTime) ? null : DateTime.ParseExact(endTime, "dd/MM/yyyy", CultureInfo.InvariantCulture).AddDays(1);

                var logScript = _logScriptRepository.FindAll(log => log.IdUser == idUser &&
                                                            (!start.HasValue || log.StartTime >= start.Value) &&
                                                            (!end.HasValue || log.EndTime < end.Value))
                                                    .Include(x => x.IdScriptNavigation)
                                                    .Include(x => x.LogActionScripts)
                                                    .ThenInclude(x => x.LogStepActions);


                var data = logScript.Select(x => new LogScriptDto
                {
                    Id = x.Id,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime,
                    NameScript = x.IdScriptNavigation.Name ?? string.Empty,
                    IdScript = x.IdScript,
                    ListLogAction = x.LogActionScripts.Select(y => new LogActionDto
                    {
                        Id = y.Id,
                        Name = y.Name,
                        StartTime = y.StartTime,
                        EndTime = y.EndTime,
                        IdFb = y.IdFb,
                        NameFb = y.NameFb,
                        Result = y.Result,
                        //Style = y.Style,
                        ListLogStep = y.LogStepActions.Select(x => x.StepDetail).ToList()
                    })
                    .Where(y => (!idFb.HasValue || idFb == y.IdFb))
                    .ToList()
                }).OrderByDescending(x => x.StartTime).Skip((currentPage-1)*itemsPerPage).Take(itemsPerPage).Where(x=>x.ListLogAction.Count>0);
                
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

        public ResponseBase GetLogActions(int idLogAction)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var getStep = _stepActionRepository.FindAll(x => x.IdLogAction == idLogAction)
                                                   .GroupBy(x => x.IdLogAction);

                var data = getStep.Select(x => new StepActionDto
                {
                    IdLogAction = x.First().IdLogAction,
                    ListLogStep = x.Select(x => x.StepDetail).ToList()

                });
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
