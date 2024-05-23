using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.Services;
using SmartBot.Services.ClassConfigFacebook;
using SmartBot.Services.Comment;
using SmartBot.Services.Content;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContentController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private readonly IContentService _contentService;

        public ContentController(IMapper mapper, IMyTypedClientServices client, IContentService contentService)
        {
            _mapper = mapper;
            _client = client;
            _contentService = contentService;
        }

        [HttpGet("list-content")]
        public ResponseBase GetListContentByType(int idUser, string hwId, byte type)
        {
            var item = _contentService.GetListContentByType( idUser,  hwId,  type);
            return item;
        }

    }
}
