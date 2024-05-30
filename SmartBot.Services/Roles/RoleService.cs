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

        public RoleService(ICommonRepository<User> userRepository, CommonDBContext context)
        {
            _userRepository = userRepository;
            _context = context;
        }

        public bool? CheckUserRole(Common.Enums.Role[] roles, int userId)
        {
            User? user = _context.Users.Include(u => u.UserRoles).SingleOrDefault(u => u.Id == userId);
            List<UserRole>? list = user?.UserRoles.ToList();
            if (list == null) 
            { 
                return null;       
            }
            foreach (UserRole item in list)    
            {
                if(roles.Contains((Common.Enums.Role)item.IdRole))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
