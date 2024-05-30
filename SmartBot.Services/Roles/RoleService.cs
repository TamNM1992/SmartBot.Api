using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;

namespace SmartBot.Services.Roles
{
    public class RoleService : IRoleService
    {
        private readonly ICommonRepository<User> _userRepository;

        public RoleService(ICommonRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CheckUserRole(Common.Enums.Role[] roles, int userId)
        {
            User? user = _userRepository.GetById(userId);
            Common.Enums.Role role = user?.UserName == "admin" ? Common.Enums.Role.ADMIN : Common.Enums.Role.USER;
            return roles.Contains(role);
        }
    }
}
