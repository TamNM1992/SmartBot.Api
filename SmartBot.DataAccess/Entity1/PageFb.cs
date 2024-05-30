using System;
using System.Collections.Generic;

namespace SmartBot.Api.Entity;

public partial class PageFb
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public int IdFaceBook { get; set; }

    public string? Type { get; set; }

    public string? Distance { get; set; }

    public string? Rate { get; set; }

    public string? Status { get; set; }

    public string? Price { get; set; }

    public string? NumPostPerDay { get; set; }

    public int? NumFollowers { get; set; }

    public string? Description { get; set; }

    public DateTime? DateUpdate { get; set; }

    public virtual AccountFb IdFaceBookNavigation { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
