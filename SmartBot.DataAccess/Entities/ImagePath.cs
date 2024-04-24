using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class ImagePath
{
    public int Id { get; set; }

    public string Path { get; set; } = null!;

    public int IdUser { get; set; }

    public string? HardwareId { get; set; }

    public virtual ICollection<CommentFb> CommentFbs { get; set; } = new List<CommentFb>();

    public virtual User IdUserNavigation { get; set; } = null!;
}
