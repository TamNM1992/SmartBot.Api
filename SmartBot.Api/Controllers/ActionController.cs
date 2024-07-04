using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.Services.Action;
using System.Globalization;

namespace SmartBot.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private readonly IActionsService _service;
        public ActionController(IActionsService service)
        {
            _service = service;
        }

        [HttpGet("action-history")]

        public ResponseBase GetActionHistory(string token, string? startTime, string? endTime, int? IdFb, int? ActionId)
        {
            return _service.GetActionHistory(token, startTime, endTime, IdFb, ActionId);

        }

        [HttpGet("action-type")]
        public ResponseBase GetActionType()
        {
            return _service.GetActionType();
        }

        [HttpGet("log-action")]

        public ResponseBase GetLogActions(int idLogaction)
        {
            return _service.GetLogActions(idLogaction);
        }
    }
}
