


using SmartBot.DataDto.Base;
using SmartBot.DataDto.User;

namespace SmartBot.Services.Users
{
    public interface IUserService
    {
        public ResponseBase CheckUserByAccount(string email, string password);
        public ResponseBase CheckUserByToken(string token);
        public ResponseBase Register(UserDto data);

    }
}
