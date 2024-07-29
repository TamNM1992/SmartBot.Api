using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.FakeData
{
    public class FakeDataDto
    {
        public string? Label { get; set; } = null;
        public DTset? Data { get; set; }

    }

    public class DTset
    { 
        public int Dataset1 { get; set; }
        public int Dataset2 { get; set; }
        public int Dataset3 { get; set; }
    } 
}
