using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class LogScript
{
    public int Id { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int IdScript { get; set; }

    public int IdUser { get; set; }

    public int IdClient { get; set; }

    public virtual ClientCustomer IdClientNavigation { get; set; } = null!;

    public virtual Script IdScriptNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<LogActionScript> LogActionScripts { get; set; } = new List<LogActionScript>();
}
