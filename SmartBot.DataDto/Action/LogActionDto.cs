namespace SmartBot.DataDto.Action
{
    public class LogScriptDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int IdScript { get; set; }
        public string NameScript { get; set; }   
        public List<LogActionDto>? ListLogAction { get; set; }
    }
    public class LogActionDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int IdFb { get; set; }
        public string NameFb { get; set; } = null!;
        public bool Result { get; set; }
        public byte Style { get; set; }
        public List<string>? ListLogStep { get; set; }
    }

    public class StepActionDto
    {
        public int IdLogAction { get; set; }
        public List<string>? ListLogStep { get; set; }
    }
}
