using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Script;
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
        [HttpPost("import-script")]
        public ResponseBase ImportScript(List<ScriptImportExcelDto> param)
        {
            var item = _ScriptService.ImportScript(param);
            return item;
        }
        [HttpPost("script")]
        public ResponseBase CreateScript(ScriptDto param)
        {
            var item = _ScriptService.CreateScript(param);
            return item;
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
        [HttpGet("list-content")]
        public ResponseBase GetContentByActionDetail(int idUser, int idAccountFB, string hardwareId)
        {
            var item = _ScriptService.GetContentByActionDetail(idUser, idAccountFB, hardwareId);
            return item;
        }
        [HttpGet("list-target")]
        public ResponseBase GetTargetByActionDetail(int idUser, int idAccountFB, int typeAction)
        {
            var item = _ScriptService.GetTargetByActionDetail(idUser, idAccountFB, typeAction);
            return item;
        }
        [HttpGet("content-detail")]
        public ResponseBase GetContentById(int idContent, string hardwareId)
        {
            var item = _ScriptService.GetContentById(idContent, hardwareId);
            return item;
        }
        [HttpGet("post-detail")]
        public ResponseBase GetPostById(int idPost)
        {
            var item = _ScriptService.GetPostById(idPost);
            return item;
        }
        [HttpPut("content")]
        public ResponseBase UpdateContent(UpdateContentParam param)
        {
            var item = _ScriptService.UpdateContent(param);
            return item;
        }
        [HttpGet("post-target")]
        public ResponseBase GetPostTarget(int idTarget, int typeTarget)
        {
            var item = _ScriptService.GetPostTarget(idTarget, typeTarget);
            return item;
        }
        [HttpPost("log-script")]
        public ResponseBase LogScript(LogScriptInputData param)
        {
            var item = _ScriptService.LogScript(param);
            return item;
        }
    }
}
