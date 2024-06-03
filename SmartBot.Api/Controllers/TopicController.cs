using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.Services.AccountFB;
using SmartBot.Services;
using SmartBot.Services.Topics;
using SmartBot.DataDto.Base;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private readonly ITopicService _topicService;

        public TopicController(IMapper mapper, IMyTypedClientServices client, ITopicService topicService)
        {
            _mapper = mapper;
            _client = client;
            _topicService = topicService;
        }

        [HttpGet("get-all-topic")]
        public ResponseBase GetAllTopic()
        {
            var item = _topicService.GetAllTopic();
            return item;
        }
    }
}
