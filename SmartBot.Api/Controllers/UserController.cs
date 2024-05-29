using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.Api.Attributes;
using SmartBot.Api.Middleware;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.User;
using SmartBot.Services;
using SmartBot.Services.Users;

namespace SmartBot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class UserController : BaseAPIController
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
        public ResponseBase CheckUserByAccount(string userName, string password, string hardwareId)
        {
            var item = _userService.CheckUserByAccount(userName, password, hardwareId);
            return item;
        }
        [HttpGet("check-token")]
        public ResponseBase CheckUserByToken(string token)
        {
            var item = _userService.CheckUserByToken(token);
            return item;
        }
        [HttpGet("check-license")]
        public ResponseBase CheckLicenseUser(string userName, string license)
        {
            var item = _userService.CheckLicenseUser(userName, license);
            return item;
        }
        [HttpGet("list-account")]
        [Role(Common.Enums.Role.ADMIN)]
        [Authorize]
        public ResponseBase GetAccountEverLogin(int idUser)
        {
            var item = _userService.GetAccountEverLogin(idUser);
            return item;
        }
        [HttpPost("register")]
        public ResponseBase Register(UserDto data)
        {
            var item = _userService.Register(data);
            return item;
        }
    }
}
