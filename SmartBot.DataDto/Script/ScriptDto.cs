using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Script
{
    public class ScriptDto
    {
        public string Name { get; set; }
        public int IdUser { get; set; }
        public string HardwareId { get; set; }
        public List<ActionDto> ListAction { get; set; }
    }
    public class ActionDto
    {
        public int IdAccountFb { get; set; }
        public byte Style { get; set; }
        public int SequenceNumber { get; set; }
        public int? IdContent { get; set; }
        public int IdTarget { get; set; }
        public byte TypeTarget { get; set; }
    }

}
