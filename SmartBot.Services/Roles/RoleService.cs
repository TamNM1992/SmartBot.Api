
using SmartBot.Common.Enums;
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

        public bool CheckUserRole(Role[] roles, int userId)
        {
            User? user = _userRepository.GetById(userId);
            Role role = user?.UserName == "admin" ? Role.ADMIN : Role.USER;
            return roles.Contains(role);
        }
    }
}
