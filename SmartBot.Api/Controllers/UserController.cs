using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.User;
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

        //[Authorize, Role(Vips.Vip2, Vips.Vip3, Vips.Vip4, Vips.Vip5)]
        [HttpGet("list-account")]
        public ResponseBase GetAccountEverLogin(int idUser)
        {
            var item = _userService.GetAccountEverLogin(idUser);
            return item;
        }
        [HttpGet("list-accountFb")]
        public ResponseBase GetAccountFbEverLogin(int idUser)
        {
            var item = _userService.GetAccountFbEverLogin(idUser);
            return item;
        }
        [HttpPost("register")]
        public ResponseBase Register(UserDto data)
        {
            var item = _userService.Register(data);
            return item;
        }
        
        [HttpGet("userlogin")]
        public ResponseBase GetUser(string userName, string passWord)
        {
            var item = _userService.GetUser(userName, passWord);
            return item;
        }
        
        [HttpGet("checkExitUser")]
        public ResponseBase CheckExitUser(string userName)
        {
            var item = _userService.CheckExitUser(userName);
            return item;
        }
        
        [HttpGet("account-client")]
        public ResponseBase GetAccountClient(int userId)
        {
            return _userService.GetAccountClient(userId);
        }

        [HttpGet("account-fb")]
        public ResponseBase GetAccountFb(int userId)
        {
            return _userService.GetAccountFb(userId);
        }
        
        [HttpGet("get-user-by-id")]
        public ResponseBase GetUserById(int idUser)
        {
            var item = _userService.GetUserById(idUser);
            return item;
        }
        
        [HttpPut("change-password/{userId}")]

        public ResponseBase ChangePassword([Required] int userId, [Required] ChangePasswordDTO DTO)
        {
            return _userService.ChangePassword(userId, DTO);
        }
        
         [HttpGet("forgot-password")]
        public ResponseBase ForgotPassword(string userName, string license)
        {
            var item = _userService.ForgotPassword(userName, license);
            return item;
        }

    }
}
