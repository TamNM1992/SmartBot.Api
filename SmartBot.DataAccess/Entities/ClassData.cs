namespace SmartBot.DataAccess.Entities;

public partial class ClassData
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string ClassName { get; set; } = null!;

    public byte ClassIndex { get; set; }

    public DateTime DateUpdate { get; set; }

    public byte Platform { get; set; }

    public byte Type { get; set; }
}
