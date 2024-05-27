using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Contents
{
    public class CreateNewContentParam
    {
        public int IdUser { get; set; }
        public string HwId { get; set; }
        public string Detail { get; set; }
        public string? ImgPath { get; set; }
        public byte TypeContent { get; set; }
    }
}
