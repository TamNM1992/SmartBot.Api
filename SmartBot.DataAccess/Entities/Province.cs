using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class Province
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? KeyWord { get; set; }

    public int? OrderNum { get; set; }

    public virtual ICollection<District> Districts { get; set; } = new List<District>();
}
