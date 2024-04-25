using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class District
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? KeyWord { get; set; }

    public int IdProvince { get; set; }

    public int? OrderNum { get; set; }

    public virtual Province IdProvinceNavigation { get; set; } = null!;
}
