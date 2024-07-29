using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.FakeData
{
    public class FakeDataDto
    {
        public string label { get; set; } = null;
        public DTset data { get; set; }

    }

    public class DTset
    { 
        public int dataset1 { get; set; }
        public int dataset2 { get; set; }
        public int dataset3 { get; set; }
    } 
}
