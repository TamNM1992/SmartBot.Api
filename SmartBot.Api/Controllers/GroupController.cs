using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.Services;
using SmartBot.Services.ClassConfigFacebook;
using SmartBot.Services.Group;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private readonly IGroupService _GroupService;

        public GroupController(IMapper mapper, IMyTypedClientServices client,IGroupService GroupService)
        {
            _mapper = mapper;
            _client = client;
            _GroupService = GroupService;
        }

        [HttpGet("Group-post")]
        public ResponseBase GetDataGroupPost()
        {
            var item = _GroupService.GetDataGroupPost();
            return item;
        }
        [HttpGet("province")]
        public ResponseBase GetProvince()
        {
            var item = _GroupService.GetProvince();
            return item;
        }
    }
}
