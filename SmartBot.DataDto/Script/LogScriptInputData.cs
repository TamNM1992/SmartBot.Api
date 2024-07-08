using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Script
{
    public class LogScriptInputData
    {
        public int IdUser { get; set; }
        public int IdScript { get; set; }
        public string HardwareId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<ActionResultDto> ListActionResult { get; set; }
    }
    public class ActionResultDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int IdFB { get; set; }
        public string? NameFB { get; set; }
        public string? ResultDetail { get; set; }
        public bool Result { get; set; }
        public List<string> ListStep { get; set; }
        public int SequenceNumber { get; set; }

    }
    public class StepResultDto
    {
        public List<string> StepResult { get; set; }
        public bool Result { get; set; }
    }
    public class ActionOutput<T>
    {
        public T Output { get; set; }
        public ActionResultDto ActionResult { get; set; }
    }
    public class StepOutput<T>
    {
        public T Output { get; set; }
        public bool Result { get; set; }
        public List<string> StepResult { get; set; }
    }
}
