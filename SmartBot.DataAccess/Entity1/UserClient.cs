using System;
using System.Collections.Generic;

namespace SmartBot.Api.Entity;

public partial class UserClient
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public int IdClient { get; set; }

    public string Token { get; set; } = null!;

    public DateTime DateUpdate { get; set; }

    public byte Status { get; set; }

    public virtual ClientCustomer IdClientNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
