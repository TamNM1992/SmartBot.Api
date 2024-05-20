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
        [Description("PostStep")]
        PostStep = 0,
        [Description("Account")]
        Account = 1,
        [Description("Post")]
        Post = 2,
        [Description("Page")]
        Page = 3,
        [Description("Group")]
        Group = 4,
        [Description("Comment")]
        Comment = 5,
    }
}
