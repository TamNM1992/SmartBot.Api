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

        [HttpGet("history")]
        public ResponseBase GetActionHistory(string token, DateTime? start, DateTime? end, int? IdFb, int? ActionId)
        {
            return _service.GetActionHistory(token, start, end, IdFb, ActionId);
        }
    }
}
