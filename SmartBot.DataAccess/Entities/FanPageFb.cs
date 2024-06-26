using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class FanPageFb
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdFb { get; set; }

    public string? Link { get; set; }

    public byte Status { get; set; }

    public DateTime DateCreate { get; set; }

    public DateTime? DateUpdate { get; set; }

    public virtual AccountFb IdFbNavigation { get; set; } = null!;
}
