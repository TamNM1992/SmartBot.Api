using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartBot.Api.Attributes;
using SmartBot.DataDto.Base;
using SmartBot.Services;
using SmartBot.Services.Comment;
namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CommentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private readonly ICommentService _commentService;

        public CommentController(IMapper mapper, IMyTypedClientServices client, ICommentService commentService)
        {
            _mapper = mapper;
            _client = client;
            _commentService = commentService;
        }

        [HttpGet("comment-group")]
        public ResponseBase GetDataCommentGroup()
        {
            var item = _commentService.GetDataCommentGroup();
            return item;
        }

    }
}
