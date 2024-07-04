﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartBot.Common.Helpers;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Action;
using SmartBot.DataDto.Base;


namespace SmartBot.Services.Action
{
    public class ActionsService : IActionsService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<LogActionScript> _logActionRepository;
        private readonly ICommonRepository<ActionType> _actionTypeRepository;
        private readonly ICommonRepository<Script> _scriptRepository;

        public ActionsService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<ActionType> actionTypeRepository,
            ICommonRepository<LogActionScript> logActionRepository, ICommonRepository<Script> scriptRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _logActionRepository = logActionRepository;
            _actionTypeRepository = actionTypeRepository;
            _scriptRepository = scriptRepository;
        }

        public ResponseBase GetActionHistory(string token, DateTime? start, DateTime? end, int? idFb, int? actionId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var idUser = int.Parse(Token.Authentication(token));
                var logActions = _logActionRepository.FindAll(x => x.IdUser == idUser).GroupBy(x => x.IdScript);

                var data = logActions.Select(x => new LogScriptDto
                {
                    ScriptName = x.FirstOrDefault().IdScriptNavigation.Name,
                    ListLogAction = logActions.Select(x => new LogActionDto
                    {
                        Id = x.FirstOrDefault().Id,
                        Name = x.FirstOrDefault().Name,
                        StartTime = x.FirstOrDefault().StartTime,
                        EndTime = x.FirstOrDefault().EndTime,
                        IdFb = x.FirstOrDefault().IdFb,
                        NameFb = x.FirstOrDefault().NameFb,
                        Result = x.FirstOrDefault().Result,
                        ListLogStep = x.FirstOrDefault().LogStepActions.Select(x => x.StepDetail).ToList()
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
    }
}
