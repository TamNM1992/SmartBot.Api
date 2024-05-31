using Microsoft.EntityFrameworkCore;
using SmartBot.DataAccess.DBContext;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;

namespace SmartBot.Services.Roles
{
    public class RoleService : IRoleService
    {
        private readonly ICommonRepository<User> _userRepository;
        private readonly CommonDBContext _context;
        private readonly ICommonRepository<UserRole> _userRoleRepository;

        public RoleService(ICommonRepository<User> userRepository, CommonDBContext context, ICommonRepository<UserRole> userRoleRepository)
        {
            _userRepository = userRepository;
            _context = context;
            _userRoleRepository = userRoleRepository;
        }

        public bool? CheckUserRole(Common.Enums.Role[] roles, int userId)
        {
            User? user = _userRepository.GetById(userId);
            if (user == null)
            {
                return null;
            }
            List<UserRole> list = _userRoleRepository.FindAll(ur => ur.IdUser == userId).Include(ur => ur.IdRoleNavigation).ToList();

            // ---------------------------------check  role --------------------------
            if(list.Count == 0)
            {
                return false;
            }

            foreach (UserRole item in list)
            {
                int maxRole = list.Max(ur => ur.IdRoleNavigation.Code);
                if (maxRole == (int)Common.Enums.Role.VIP1)
                {
                    return false;
                }
            }

            foreach (UserRole item in list)
            {
                if (roles.Contains((Common.Enums.Role)item.IdRoleNavigation.Code))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
