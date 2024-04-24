using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class FaceBookGroup
{
    public int Id { get; set; }

    public int IdFaceBook { get; set; }

    public int IdGroupFb { get; set; }

    public bool Joined { get; set; }

    public DateTime? DateUpdate { get; set; }

    public virtual AccountFb IdFaceBookNavigation { get; set; } = null!;

    public virtual GroupFb IdGroupFbNavigation { get; set; } = null!;
}
