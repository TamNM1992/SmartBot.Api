using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class PostComment
{
    public int Id { get; set; }

    public int IdPost { get; set; }

    public string Detail { get; set; } = null!;

    public int? IdSuperior { get; set; }

    public virtual Post IdPostNavigation { get; set; } = null!;
}
