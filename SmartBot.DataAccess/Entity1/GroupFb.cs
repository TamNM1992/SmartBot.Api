using System;
using System.Collections.Generic;

namespace SmartBot.Api.Entity;

public partial class GroupFb
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public int IdFaceBook { get; set; }

    public string? Type { get; set; }

    public int? NumMember { get; set; }

    public int? NumPostPerDay { get; set; }

    public string? Description { get; set; }

    public DateTime? DateUpdate { get; set; }

    public virtual AccountFb IdFaceBookNavigation { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
