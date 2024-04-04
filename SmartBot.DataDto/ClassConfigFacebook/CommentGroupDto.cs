using SmartBot.DataDto.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.ClassConfigFacebook
{
    public class CommentGroupDataDto
    {
        public int DelayTimeLoad {  get; set; }
        public int DelayAction { get; set; }
        public ClassFB CommentBox { get; set; }
        public ClassFB ButtonImg { get; set; }
        public ClassFB ButtonSubmit {  get; set; }
    }
}
