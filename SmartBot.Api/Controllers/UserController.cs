using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.User;
using SmartBot.Services;
using SmartBot.Services.Users;
using SmartBot.Common.Enums;
using SmartBot.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;
using Microsoft.Graph.Models;
using User = SmartBot.DataAccess.Entities.User;
using SmartBot.Common.Helpers;

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

        [HttpGet("list-accountClient")]
        public ResponseBase GetAccountsClient(string token)
        {
            var idUser = int.Parse(Token.Authentication(token));
            var item = _userService.GetAccountEverLogin(idUser);
            return item;
        }

        [HttpGet("list-accountFb")]
        public ResponseBase GetAccountFbEverLogin(string token)
        {
            var idUser = int.Parse(Token.Authentication(token));
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

        [HttpPut("change-password")]
        public ResponseBase ChangePassword(ChangePasswordDto passwordDto)
        {
            return _userService.ChangePassword(passwordDto);
        }

        [HttpGet("checkExitUser")]
        public ResponseBase CheckExitUser(string userName)
        {
            var item = _userService.CheckExitUser(userName);
            return item;
        }

        [HttpGet("forgot-password")]
        public ResponseBase ForgotPassword(string userName, string license)
        {
            var item = _userService.ForgotPassword(userName, license);
            return item;
        }

        [HttpGet("get-user-by-id")]
        public ResponseBase GetUserById(int idUser)
        {
            var item = _userService.GetUserById(idUser);
            return item;
        }

    }
}
