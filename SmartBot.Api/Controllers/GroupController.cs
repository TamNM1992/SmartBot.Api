using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Group;
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
        [HttpGet("type-result")]
        public ResponseBase GetTypeByKey(string key)
        {
            var item = _GroupService.GetTypeByKey(key);
            return item;
        }
        [HttpGet("group-by-type")]
        public ResponseBase GetGroupByTypeAndLocation(string type, string location, string profile)
        {
            var item = _GroupService.GetGroupByTypeAndLocation(type, location,profile);
            return item;
        }
        [HttpGet("search-config")]
        public ResponseBase GetSearchConfig()
        {
            var item = _GroupService.GetSearchConfig();
            return item;
        }
        [HttpPost("group-fb")]
        public ResponseBase InsertGroup(InsertGroupDto data)
        {
            var item = _GroupService.InsertGroup(data);
            return item;
        }
        [HttpGet("group-fb")]
        public ResponseBase GetJoinedGroup(int idFacebook)
        {
            var item = _GroupService.GetJoinedGroup(idFacebook);
            return item;
        }
    }
}
