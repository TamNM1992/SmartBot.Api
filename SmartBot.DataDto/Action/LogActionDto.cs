
namespace SmartBot.DataDto.Action
{
    public class LogActionDto
    {
        public int IdFb { get; set; }
        public string? NameFb { get; set; }
        public byte Action { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Result { get; set; }
        public string ResultDetail { get; set; } = string.Empty;
    }
}
