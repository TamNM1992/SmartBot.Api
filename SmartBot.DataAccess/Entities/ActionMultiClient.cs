using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class ActionMultiClient
{
    public int Id { get; set; }

    public int IdScriptMultiClient { get; set; }

    public int IdAccountFb { get; set; }

    public int IdClient { get; set; }

    public byte Styte { get; set; }

    public int SequenceNumber { get; set; }

    public int? IdContent { get; set; }

    public DateTime DateUpdate { get; set; }

    public int? IdTarget { get; set; }

    public byte TypeTarget { get; set; }

    public string? Link { get; set; }

    public int? NumberGet { get; set; }

    public string? KeyWord { get; set; }

    public bool Result { get; set; }

    public DateTime? EndTime { get; set; }
}
