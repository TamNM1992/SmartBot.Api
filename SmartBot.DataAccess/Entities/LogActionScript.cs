using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class LogActionScript
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int IdFb { get; set; }

    public int IdScript { get; set; }

    public int IdClient { get; set; }

    public int IdUser { get; set; }

    public string NameFb { get; set; } = null!;

    public string? ResultDetail { get; set; } = null!;

    public bool Result { get; set; }

    public virtual ClientCustomer IdClientNavigation { get; set; } = null!;

    public virtual AccountFb IdFbNavigation { get; set; } = null!;

    public virtual Script IdScriptNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<LogStepAction> LogStepActions { get; set; } = new List<LogStepAction>();
}
