using SmartBot.DataDto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Script
{
    public class ScriptDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ActionDataDto > ListActions { get; set; }
    }
    public class ActionDataDto
    {
        public int Id { get; set; }
        public AccountFbDto Account { get; set; }
        public string? Link {  get; set; }
        public byte Style { get; set; }
        public int SequenceNumber { get; set; }
        public int? NumberGet { get; set; }
        public string?KeyWord { get; set; }
        public ContentDataDto? Content { get; set; }
        public TargetDataDto? Target { get; set; }
    }
    public class ContentDataDto
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public byte Type { get; set; }

    }
    public class AccountDataDto
    {
        public int Id { set; get; }
        public string FbUser { get; set; }
        public string FbPassword { get; set; }
        public string FbProfileLink {  get; set; }
    }
    public class TargetDataDto
    {
        public byte Type { get; set; }
        public int? IdTarget { get; set; }
    }
}
