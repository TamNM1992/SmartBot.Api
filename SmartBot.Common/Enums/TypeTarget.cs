using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.Common.Enums
{
    public enum TypeTarget
    {
        [Description("MyProfile")]
        MyProfile = 0,
        [Description("OrtherProfile")]
        OrtherProfile = 1,
        [Description("Page")]
        Page = 2,
        [Description("Group")]
        Group = 3,
        [Description("Comment")]
        Comment = 4,
        [Description("Post")]
        Post = 5,
        [Description("PostBefore")]
        PostBefore = 6,
        [Description("LinkBefore")]
        LinkBefore = 7,
    }
}
