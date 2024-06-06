using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartBot.Common.Enums;
using System.Threading.Tasks;

namespace SmartBot.Services.Roles
{
    public interface IRoleService
    {
        bool CheckUserRole(role[] roles, int idUser);
    }
}
