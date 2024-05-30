using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.User
{
    public class AccountDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
    public class AccountFbDto
    {
        public int IdFb { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
