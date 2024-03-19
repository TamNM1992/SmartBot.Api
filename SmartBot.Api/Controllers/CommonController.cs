using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.Services;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommonController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;

        public CommonController(IMapper mapper, IMyTypedClientServices client)
        {
            _mapper = mapper;
            _client = client;
        }

        [HttpGet("dashboard")]
        public ResponseBase GetDashBoard(int IdCtv)
        {
            return new ResponseBase();
        }
    }
}
