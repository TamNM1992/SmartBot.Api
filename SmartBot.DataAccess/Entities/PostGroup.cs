using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class PostGroup
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public int IdGroup { get; set; }

    public string Content { get; set; } = null!;

    public DateTime? DateUpdate { get; set; }

    public virtual GroupFb IdGroupNavigation { get; set; } = null!;
}
