using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class GroupFb
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int NumMember { get; set; }

    public int NumPostPerDay { get; set; }

    public string? Description { get; set; }

    public DateTime? DateUpdate { get; set; }

    public virtual ICollection<FaceBookGroup> FaceBookGroups { get; set; } = new List<FaceBookGroup>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
