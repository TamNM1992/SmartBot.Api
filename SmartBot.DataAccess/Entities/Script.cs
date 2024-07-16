using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class Script
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public DateTime DateUpdate { get; set; }

    public byte Status { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual ICollection<LogScript> LogScripts { get; set; } = new List<LogScript>();
}
