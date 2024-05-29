using SmartBot.Common.Enums;


namespace SmartBot.Services.Users.RoleServices
{
    public interface IRoleService
    {
        bool CheckUserRole(Roles[] roles, int userId);
    }
}
