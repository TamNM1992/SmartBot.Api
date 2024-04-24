using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class CommentFb
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public int IdFaceBook { get; set; }

    public int? IdImage { get; set; }

    public DateTime? DateUpdate { get; set; }

    public virtual AccountFb IdFaceBookNavigation { get; set; } = null!;

    public virtual ImagePath? IdImageNavigation { get; set; }
}
