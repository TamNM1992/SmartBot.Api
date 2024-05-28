using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.Common.Enums
{
    public enum TypeContent
    {
        [Description("NewFeed")]
        NewFeed = 1,
        [Description("PostGroup")]
        PostGroup = 2,
        [Description("Comment")]
        Comment = 3,
    }
}
