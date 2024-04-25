using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class ContentFb
{
    public int Id { get; set; }

    public string Detail { get; set; } = null!;

    public int IdFaceBook { get; set; }

    public DateTime? DateUpdate { get; set; }

    public byte? Type { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual ICollection<ContentTopic> ContentTopics { get; set; } = new List<ContentTopic>();

    public virtual AccountFb IdFaceBookNavigation { get; set; } = null!;
}
