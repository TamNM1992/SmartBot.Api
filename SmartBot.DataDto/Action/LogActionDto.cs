

namespace SmartBot.DataDto.Action
{
    public class LogScriptDto
    {
        public string ScriptName { get; set; }
        public List<LogActionDto> ListLogAction { get; set; }
        
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
        public List<string> ListLogStep { get; set; }
    }
}
