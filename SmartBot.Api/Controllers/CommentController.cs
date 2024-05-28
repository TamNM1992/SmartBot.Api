using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.Services;
using SmartBot.Services.ClassConfigFacebook;
using SmartBot.Services.Comment;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : BaseAPIController
    {

        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private readonly ICommentService _commentService;

        public CommentController(IMapper mapper, IMyTypedClientServices client,ICommentService commentService)
        {
            _mapper = mapper;
            _client = client;
            _commentService = commentService;
        }

        [HttpGet("comment-group")]
        [Authorize]
        public ResponseBase GetDataCommentGroup()
        {
            string? id = getUserId();
            if (id == "2")
            {
                var item = _commentService.GetDataCommentGroup();
                return item;
            }
            return new ResponseBase()
            {
                Code = 403,
                Message = "You are not authorized to do this operation",
                Data = id
            };
        }

    }
}
