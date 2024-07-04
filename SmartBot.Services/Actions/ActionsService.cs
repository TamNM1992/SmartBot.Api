using AutoMapper;
using SmartBot.Common.Helpers;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Action;
using SmartBot.DataDto.Base;
using System.Globalization;

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

        public ActionsService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<ActionType> actionTypeRepository,
            ICommonRepository<LogActionScript> logActionRepository, ICommonRepository<Script> scriptRepository, ICommonRepository<LogStepAction> stepActionRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _logActionRepository = logActionRepository;
            _actionTypeRepository = actionTypeRepository;
            _scriptRepository = scriptRepository;
            _stepActionRepository = stepActionRepository;
        }

        public ResponseBase GetActionHistory(string token, string? startTime, string? endTime, int? idFb, int? actionId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var idUser = int.Parse(Token.Authentication(token));

                DateTime? start = string.IsNullOrEmpty(startTime) ? null : DateTime.ParseExact(startTime, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime? end = string.IsNullOrEmpty(endTime) ? null : DateTime.ParseExact(endTime, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                var logActions = _logActionRepository.FindAll(log => log.IdUser == idUser &&
                                                    (!start.HasValue || log.StartTime >= start.Value) &&
                                                    (!end.HasValue || log.EndTime <= end.Value) &&
                                                    (!idFb.HasValue || log.IdFb == idFb.Value));


                var data = logActions.GroupBy(x => x.IdScript).Select(x => new LogScriptDto
                {
                    ScriptName = x.First().IdScriptNavigation.Name ?? string.Empty,
                    ListLogAction = logActions.Select(x => new LogActionDto
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
                }).ToList();

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
