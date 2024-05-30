using System;
using System.Collections.Generic;

namespace SmartBot.Api.Entity;

public partial class ClientCustomer
{
    public int Id { get; set; }

    public string HardwareId { get; set; } = null!;

    public DateTime DateUpdate { get; set; }

    public virtual ICollection<ImagePath> ImagePaths { get; set; } = new List<ImagePath>();

    public virtual ICollection<UserClient> UserClients { get; set; } = new List<UserClient>();
}
