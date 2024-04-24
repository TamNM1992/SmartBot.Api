using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte Status { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdate { get; set; }

    public string? HardwareId { get; set; }

    public string? License { get; set; }

    public virtual ICollection<ImagePath> ImagePaths { get; set; } = new List<ImagePath>();
}
