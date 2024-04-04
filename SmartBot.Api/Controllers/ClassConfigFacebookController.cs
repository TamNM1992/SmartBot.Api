using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.Services;
using SmartBot.Services.ClassConfigFacebook;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassConfigFacebookController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private readonly IClassConfigFacebookService _classConfigFacebookService;


        public ClassConfigFacebookController(IMapper mapper, IMyTypedClientServices client, IClassConfigFacebookService classConfigFacebookService)
        {
            _mapper = mapper;
            _client = client;
            _classConfigFacebookService = classConfigFacebookService;
        }

        [HttpGet("comment-group")]
        public ResponseBase GetCommentGroup()
        {
            var item = _classConfigFacebookService.GetCommentGroup();
            return item;
        }
    }
}
