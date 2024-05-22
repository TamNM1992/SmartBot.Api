using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class PageFb
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Distance { get; set; }

    public string? Rate { get; set; }

    public string? Status { get; set; }

    public string? Price { get; set; }

    public string? NumPostPerDay { get; set; }

    public int NumFollowers { get; set; }

    public string? Description { get; set; }

    public DateTime? DateUpdate { get; set; }

    public virtual ICollection<FaceBookPage> FaceBookPages { get; set; } = new List<FaceBookPage>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
