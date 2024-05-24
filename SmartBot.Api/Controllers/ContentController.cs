using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Contents;
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

        [HttpPost("content")]
        public ResponseBase InsertDefaultContent(CreateNewContentParam param)
        {
            var item = _contentService.InsertDefaultContent(param);
            return item;
        }
        [HttpGet("list-content")]
        public ResponseBase GetListContentByType(int idUser, string hwId, byte type)
        {
            var item = _contentService.GetListContentByType( idUser,  hwId,  type);
            return item;
        }
        [HttpGet("content-by-id")]
        public ResponseBase GetContentById(int idContent, string hwId)
        {
            var item = _contentService.GetContentById(idContent, hwId);
            return item;
        }
    }
}
