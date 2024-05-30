using System;
using System.Collections.Generic;

namespace SmartBot.Api.Entity;

public partial class ActionType
{
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    public byte Status { get; set; }
}
