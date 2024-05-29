using SmartBot.Common.Enums;

namespace SmartBot.Services.Roles
{
    public interface IRoleService
    {
        bool CheckUserRole(Role[] roles, int userId);
    }
}
