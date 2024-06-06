using SmartBot.Common.Enums;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;

namespace SmartBot.Services.Users.RoleServices
{
    //public class RoleService : IRoleService
    //{
    //    private readonly IRepository<UserRole> _userRoleRepository;

    //    public RoleService(ICommonRepository<UserRole> userRoleRepository)
    //    {
    //        _userRoleRepository = userRoleRepository;
    //    }

    //    public bool IsUserHasRole(Vips[] roles, int userId)
    //    {
    //        // Lấy tất cả các userRoles từ repository
    //        var query = _userRoleRepository.FindAll(
    //            ur => ur.IdUser == userId,
    //            ur => ur.IdRoleNavigation
    //        );

    //        // Lấy các roles của người dùng
    //        var userRoles = query.Select(ur => ur.IdRoleNavigation).ToList();

    //        foreach (var role in userRoles)
    //        {
    //            if (roles.Contains((Vips)role.Code))
    //            {
    //                return true;
    //            }
    //        }

    //        return false;
    //    }
    //}
}
