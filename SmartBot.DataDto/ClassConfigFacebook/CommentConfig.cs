using SmartBot.DataDto.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.ClassConfigFacebook
{
    public class CommentConfig
    {
        public int DelayPreLoad { get; set; }
        public int DelayWaitingForAction { get; set; }
        public int DelayWaitingForWriteText { get; set; }

        public string Content { get; set; }
        public ClassFB ButtonComment { get; set; }
        public ClassFB ButtonSubmit { get; set; }
    }
}
