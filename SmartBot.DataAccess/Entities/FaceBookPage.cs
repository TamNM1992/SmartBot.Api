using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class FaceBookPage
{
    public int Id { get; set; }

    public int IdFaceBook { get; set; }

    public int IdPageFb { get; set; }

    public bool Follow { get; set; }

    public DateTime? DateUpdate { get; set; }

    public virtual AccountFb IdFaceBookNavigation { get; set; } = null!;

    public virtual PageFb IdPageFbNavigation { get; set; } = null!;
}
