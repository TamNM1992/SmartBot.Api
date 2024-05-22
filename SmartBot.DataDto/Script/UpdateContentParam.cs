using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Script
{
    public class UpdateContentParam
    {
        public int IdUser { get; set; }
        public string HwId { get; set; }
        public int IdContent { get; set; }
        public string Detail { get; set; }
        public string? PathImg { get; set; }
        public int? IdImg { get; set; }
    }
}
