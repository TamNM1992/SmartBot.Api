using SmartBot.DataDto.Img;
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
        public List<string> ListTopic { get; set; } = null!;
        public ImgDto? Img { get; set; }
    }
}
