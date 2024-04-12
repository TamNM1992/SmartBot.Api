using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Group
{
    public class PageDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public int? NumFollowers { get; set; }
        public string? Description { get; set; }
        public bool IsFollowing { get; set; }
    }
    public class GroupDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public int? NumMember { get; set; }
        public int? NumPostPerDay { get; set; }
        public string? Description { get; set; }
        public bool IsJoined { get; set; }
    }
}
