using SmartBot.Common.Enums;


namespace SmartBot.Services.Users.RoleServices
{
    public interface IRoleService
    {
        bool IsUserHasRole(Vips[] roles, int userId);
      
    }
}

