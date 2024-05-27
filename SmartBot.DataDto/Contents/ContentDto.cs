using SmartBot.DataDto.Img;
using SmartBot.DataDto.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Contents
{
    public class ContentDto
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public List<ImgDto>? ListImg { get; set; }
    }
}
