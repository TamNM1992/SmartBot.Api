using Microsoft.AspNetCore.Http;
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
        public ResponseBase GetActionHistory(int IdUser, DateTime? start, DateTime? end)
        {
            return _service.GetActionHistory(IdUser,start,end);
        }
    }
}
