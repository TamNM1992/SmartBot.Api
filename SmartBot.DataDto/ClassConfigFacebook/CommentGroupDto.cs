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
        public ClassFB ButtonSubmit {  get; set; }
        public Dictionary<string, ClassFB> SelectPostBar { get; set; }
        public Dictionary<string, ClassFB> SelectCommentBar { get; set; }
        

    }
    public class ShareGroupDataDto
    {
        public int DelayTimeLoad { get; set; }
        public int DelayAction { get; set; }
        public ClassFB ButtonShare { get; set; }
        public ClassFB ButtonSubmit { get; set; }
        public Dictionary<string, ClassFB> SelectShareBar1 { get; set; }
        public Dictionary<string, ClassFB> SelectShareBar2 { get; set; }

    }
}
