using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class ContentTopic
{
    public int Id { get; set; }

    public int IdTopic { get; set; }

    public int IdComment { get; set; }

    public int LevelCompatible { get; set; }

    public virtual ContentFb IdCommentNavigation { get; set; } = null!;

    public virtual Topic IdTopicNavigation { get; set; } = null!;
}
