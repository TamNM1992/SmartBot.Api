using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class LogStepAction
{
    public int Id { get; set; }

    public int IdLogAction { get; set; }

    public string StepDetail { get; set; } = null!;

    public bool Result { get; set; }

    public virtual LogActionScript IdLogActionNavigation { get; set; } = null!;
}
