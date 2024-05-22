using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Group
{
    public class ProvinceDto
    {
        public string Name { get; set; }
        public List<string> Districts { get; set; }
    }
    public class DistrictDto
    {
        public string Name { get; set; }
    }
}
