using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.Services;
using SmartBot.Services.ClassConfigFacebook;
using SmartBot.Services.NewFeed;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewFeedController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private readonly INewFeedService _NewFeedService;

        public NewFeedController(IMapper mapper, IMyTypedClientServices client,INewFeedService NewFeedService)
        {
            _mapper = mapper;
            _client = client;
            _NewFeedService = NewFeedService;
        }

        [HttpGet("newfeed-data")]
        public ResponseBase GetDataNewFeed()
        {
            var item = _NewFeedService.GetDataNewFeed();
            return item;
        }
    }
}
