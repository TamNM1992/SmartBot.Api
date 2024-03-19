using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.Services;
using SmartBot.Services.Users;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private readonly IUserService _userService;


        public UserController(IMapper mapper, IMyTypedClientServices client, IUserService userService)
        {
            _mapper = mapper;
            _client = client;
            _userService = userService;
        }

        [HttpGet("login-account")]
        public ResponseBase CheckUserByAccount(string email, string password)
        {
            var item = _userService.CheckUserByAccount(email, password);
            return item;
        }
        [HttpGet("check-token")]
        public ResponseBase CheckUserByToken(string token)
        {
            var item = _userService.CheckUserByToken(token);
            return item;
        }
    }
}
