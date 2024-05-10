using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class ActionType
{
    public int Id { get; set; }

    public int IdAction { get; set; }

    public int IdType { get; set; }

    public byte Status { get; set; }

    public virtual Action IdActionNavigation { get; set; } = null!;

    public virtual TypeAction IdTypeNavigation { get; set; } = null!;
}
