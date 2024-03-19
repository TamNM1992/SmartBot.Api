


using SmartBot.DataDto.Base;

namespace SmartBot.Services.Users
{
    public interface IUserService
    {
        public ResponseBase CheckUserByAccount(string email, string password);
        public ResponseBase CheckUserByToken(string token);

    }
}
