using AutoMapper;
using SmartBot.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBot.DataAccess.Interface;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;

namespace SmartBot.Services.Roles
{
    public class RoleService : IRoleService
    {
        private ICommonRepository<Role> _roleRepository;
        private ICommonRepository<UserRole> _userRoleRepository;

        private IMapper _mapper;

        public RoleService(ICommonRepository<Role> roleRepository, IMapper mapper, ICommonRepository<UserRole> userRoleRepository)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
            _userRoleRepository = userRoleRepository;
        }
        public bool CheckUserRole(role[] roles, int idUser)
        {
            var roleByUsers = _userRoleRepository.FindAll(x => x.IdUser == idUser)
                                                .Include(x => x.IdRoleNavigation);
            if (roleByUsers != null && roles.Any())
            {
                var temp = roleByUsers.Select(x => x.IdRoleNavigation.Code).ToList();
                foreach (var role in roles)
                {
                    if (temp.Contains((int)role))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
