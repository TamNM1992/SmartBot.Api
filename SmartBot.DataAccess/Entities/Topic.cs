using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class Topic
{
    public int Id { get; set; }

    public string Topic1 { get; set; } = null!;

    public string KeyWord { get; set; } = null!;

    public virtual ICollection<ContentTopic> ContentTopics { get; set; } = new List<ContentTopic>();

    public virtual ICollection<ImageTopic> ImageTopics { get; set; } = new List<ImageTopic>();
}
