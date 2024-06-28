using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.AccountFb;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Script;
using SmartBot.Services;
using SmartBot.Services.AccountFB;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountFbController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private readonly IAccountFbService _fbService;

        public AccountFbController(IMapper mapper, IMyTypedClientServices client, IAccountFbService fbService)
        {
            _mapper = mapper;
            _client = client;
            _fbService = fbService;
        }

        [HttpPost("accountFb")]
        public ResponseBase InsertAccountFb(InsertAccountFbDto param)
        {
            var item = _fbService.InsertAccountFb(param);
            return item;
        }
        [HttpGet("id-fb")]
        public ResponseBase GetFaceBookId(string fbUserName)
        {
            var item = _fbService.GetFaceBookId(fbUserName);
            return item;
        }

        [HttpGet("test-chart")]
        public ResponseBase TestChart()
        {
            var item = _fbService.TestChart();
            return item;
        }
        [HttpGet("main-info")]
        public ResponseBase CheckMainInfo(string infoName)
        {
            var item = _fbService.CheckMainInfo(infoName);
            return item;
        }
    }


}
