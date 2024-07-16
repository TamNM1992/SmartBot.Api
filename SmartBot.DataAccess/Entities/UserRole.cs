using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class UserRole
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public int IdRole { get; set; }

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
