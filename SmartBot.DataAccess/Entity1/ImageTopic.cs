using System;
using System.Collections.Generic;

namespace SmartBot.Api.Entity;

public partial class ImageTopic
{
    public int Id { get; set; }

    public int IdTopic { get; set; }

    public int IdImage { get; set; }

    public int LevelCompatible { get; set; }

    public virtual ImagePath IdImageNavigation { get; set; } = null!;

    public virtual Topic IdTopicNavigation { get; set; } = null!;
}
