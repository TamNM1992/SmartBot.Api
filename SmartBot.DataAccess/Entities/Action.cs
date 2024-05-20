using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class Action
{
    public int Id { get; set; }

    public int IdScript { get; set; }

    public int IdAccountFb { get; set; }

    public byte Style { get; set; }

    public int SequenceNumber { get; set; }

    public int? IdContent { get; set; }

    public DateTime DateUpdate { get; set; }

    public int IdTarget { get; set; }

    public byte TypeTarget { get; set; }

    public virtual ICollection<ActionType> ActionTypes { get; set; } = new List<ActionType>();

    public virtual AccountFb IdAccountFbNavigation { get; set; } = null!;

    public virtual ContentFb? IdContentNavigation { get; set; }

    public virtual Script IdScriptNavigation { get; set; } = null!;
}
