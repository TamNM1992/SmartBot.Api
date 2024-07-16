using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class ImagePath
{
    public int Id { get; set; }

    public string Path { get; set; } = null!;

    public int IdContent { get; set; }

    public int IdUser { get; set; }

    public virtual ContentFb IdContentNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<ImageTopic> ImageTopics { get; set; } = new List<ImageTopic>();
}
