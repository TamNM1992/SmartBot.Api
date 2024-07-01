using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class Script
{
    public int Id { get; set; }

    public int IdUserClient { get; set; }

    public DateTime DateUpdate { get; set; }

    public byte Status { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual ICollection<LogActionScript> LogActionScripts { get; set; } = new List<LogActionScript>();
}
