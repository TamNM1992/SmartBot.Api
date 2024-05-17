using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Script
{
    public class ScriptCreateDto
    {
        public string Name { get; set; }
        public List<ActionCreateDto> ListAction {  get; set; }
        public int IdUser { get; set; }
        public string HardwareId { get; set; }
    }
    public class ActionCreateDto
    {
        public int IdAccount { get; set; }
        public string NameAccount { get; set; }
        public int IdActionDetail {  get; set; }
        public string NameActionDetail { get; set; }

        public int IdContent { get; set; }
        public int TitleContent { get; set; }

        public int IdTarget { get; set; }
        public string TitleTarget { get; set; }

    }
}
