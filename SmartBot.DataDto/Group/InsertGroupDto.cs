using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Group
{
    public class InsertGroupDto
    {
        public string FbUser {  get; set; }
        public List<GroupDataDto> Groups { get; set; }
    }
    public class UpdateGroupDto
    {
        public int IdFb { get; set; }
        public List<GroupMiniData> Groups { get; set; }
    }
    public class InsertGroupFBDto
    {
        public int IdFaceBook { get; set; }
        public Dictionary<string,string> Groups { get;set; }
    }
}
