using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.Services.Action;

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
        public ResponseBase GetActionHistory(string token, DateTime? start, DateTime? end, int? IdFb, string? actionName)
        {
            return _service.GetActionHistory(token, start, end, IdFb, actionName);
        }

        [HttpGet("action-type")]
        public ResponseBase GetActionType()
        {
            return _service.GetActionType();
        }

        [HttpGet("get-log-action")]
        public ResponseBase GetLogActions(int idLogaction)
        {
            return _service.GetLogActions(idLogaction);
        }
    }
}
