using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class ScriptMultiClient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Status { get; set; }

    public int IdUser { get; set; }
}
