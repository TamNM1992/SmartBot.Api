using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.Services;
using SmartBot.Services.ClassConfigFacebook;
using SmartBot.Services.Scripts;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScriptController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private readonly IScriptService _ScriptService;

        public ScriptController(IMapper mapper, IMyTypedClientServices client,IScriptService ScriptService)
        {
            _mapper = mapper;
            _client = client;
            _ScriptService = ScriptService;
        }

        [HttpGet("list-script")]
        public ResponseBase GetScriptByUserClient(int idUser, string hardwareId)
        {
            var item = _ScriptService.GetScriptByUserClient(idUser, hardwareId);
            return item;
        }
        [HttpGet("list-account")]
        public ResponseBase GetListAccountForScript(int idUser)
        {
            var item = _ScriptService.GetListAccountForScript(idUser);
            return item;
        }
    }
}
