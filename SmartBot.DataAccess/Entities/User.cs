using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte Status { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdate { get; set; }

    public string? License { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public virtual ICollection<UserClient> UserClients { get; set; } = new List<UserClient>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    public virtual ICollection<UsersAccountFb> UsersAccountFbs { get; set; } = new List<UsersAccountFb>();
}
