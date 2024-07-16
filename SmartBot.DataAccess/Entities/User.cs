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

    public string? HardwareId { get; set; }
    public string? Token { get; set; }


    public virtual ICollection<ImagePath> ImagePaths { get; set; } = new List<ImagePath>();

    public virtual ICollection<LogScript> LogScripts { get; set; } = new List<LogScript>();

    public virtual ICollection<UsersAccountFb> UsersAccountFbs { get; set; } = new List<UsersAccountFb>();
}
