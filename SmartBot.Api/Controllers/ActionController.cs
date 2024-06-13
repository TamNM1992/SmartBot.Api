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
        private readonly IActionService _service;
        public ActionController(IActionService service) 
        {
            _service = service;     
        }

        [HttpGet("history")]
        public ResponseBase GetActionHistory(int IdUser)
        {
            return _service.GetActionHistory(IdUser);
        }
    }
}
