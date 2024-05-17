using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Script
{
    public class TargetScriptDto
    {
        public List<AccountTargetDto>? ListAccount {  get; set; }
        public List<GroupTargetDto>? ListGroup { get; set; }
        public List<PageTargetDto>? ListPage { get; set; }
    }
    public class AccountTargetDto
    {
        public string Type {  get; set; }
        public int Id { get; set; }
        public string FbUser { get; set; }
        public string FbProfileLink { get; set; }
        public string KeySearch { get; set; }
    }
    public class GroupTargetDto
    {
        public string Type { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
    public class PageTargetDto
    {
        public string Type { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
    public class PostTargetDto
    {
        public string Type { get; set; }
        public int Id { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
    }
    public class PostCommentTargetDto
    {
        public string Type { get; set; }
        public int Id { get; set; }
        public string Detail {  get; set; }
    }
}
