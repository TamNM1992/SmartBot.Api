using SmartBot.Common.Enums;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;

namespace SmartBot.Services.Users.RoleServices
{
    public class RoleService : IRoleService
    {
        private readonly IRepository<UserRole> _userRoleRepository;

        public RoleService(ICommonRepository<UserRole> userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
        }

        public bool IsUserHasRole(Vips[] roles, int userId)
        {
            // Lấy tất cả các userRoles từ repository
            var userRoles = _userRoleRepository.FindAll(
                ur => ur.IdUser == userId,
                ur => ur.IdRoleNavigation
            );

            // Lấy các roles code của người dùng
            var userRolesCode = userRoles.Select(ur => ur.IdRoleNavigation.Code).ToList();

            foreach (var role in roles)
            {
                if (userRolesCode.Contains((int)Vips.Vip1))
                {
                    return false;
                }

                if (userRolesCode.Contains((int)role))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
