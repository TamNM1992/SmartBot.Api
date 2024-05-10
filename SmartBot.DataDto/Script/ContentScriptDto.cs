using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Script
{
    public class ContentScriptDto
    {
        public int Id { get; set; }
        public string Detail { get; set; } = null!;
        public List<string>? ListImgPath { get; set; }
    }
}
