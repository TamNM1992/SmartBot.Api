using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class Role
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
