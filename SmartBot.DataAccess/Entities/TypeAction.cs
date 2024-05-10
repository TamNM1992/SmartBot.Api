using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class TypeAction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ActionType> ActionTypes { get; set; } = new List<ActionType>();
}
