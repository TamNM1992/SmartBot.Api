


using SmartBot.DataDto.Base;
using SmartBot.DataDto.User;

namespace SmartBot.Services.Users
{
    public interface IUserService
    {
        public ResponseBase CheckUserByAccount(string userName, string password, string hardwareId);
        public ResponseBase CheckUserByToken(string token);
        public ResponseBase Register(UserDto data);
        public ResponseBase CheckLicenseUser(string userName, string license);
        public ResponseBase GetAccountEverLogin(int idUser);
        public ResponseBase GetAccountFbEverLogin(int idUser);
    }
}
