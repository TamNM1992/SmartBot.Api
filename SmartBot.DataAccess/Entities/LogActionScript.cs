using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class LogActionScript
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int IdFb { get; set; }

    public string NameFb { get; set; } = null!;

    public string? ResultDetail { get; set; }

    public bool Result { get; set; }

    public int IdLogScript { get; set; }

    public int IdScript { get; set; }

    public virtual AccountFb IdFbNavigation { get; set; } = null!;

    public virtual LogScript IdLogScriptNavigation { get; set; } = null!;

    public virtual ICollection<LogStepAction> LogStepActions { get; set; } = new List<LogStepAction>();
}
