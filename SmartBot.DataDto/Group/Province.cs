using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Group
{
    public class Province
    {
        public string Name { get; set; }
        public List<string> Districts { get; set; }
    }
    public class District
    {
        public string Name { get; set; }
    }
}
