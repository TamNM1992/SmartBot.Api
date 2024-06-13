using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.AccountFb
{
    public class InsertAccountFbDto
    {
        public int idUser { get; set; }
        public string FbUser { get; set; }
        public string FbPassword { get; set; }
    }
    public class TestChartFbDto
    {
        public int idUser { get; set; }
        public int CountIdAccountFb { get; set; }
    }
}
