using SmartBot.DataDto.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.ClassConfigFacebook
{
    public class UpImgConfig
    {
        public int DelayPreLoad { get; set; }
        public int DelayWaitingForAction { get; set; }
        public int DelayWaitingForSendImg { get; set; }

        public string PathImg { get; set; }
        public ClassFB ButtonImg { get; set; }
        public ClassFB ButtonSubmit { get; set; }
    }
}
