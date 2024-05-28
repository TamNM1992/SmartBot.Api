using System;
using System.Collections.Generic;

namespace SmartBot.DataAccess.Entities;

public partial class AccountFb
{
    public int Id { get; set; }

    public string FbUser { get; set; } = null!;

    public string FbPassword { get; set; } = null!;

    public string FbProfileLink { get; set; } = null!;

    public string KeySearch { get; set; } = null!;

    public DateTime DateLogin { get; set; }

    public byte Status { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual ICollection<ContentFb> ContentFbs { get; set; } = new List<ContentFb>();

    public virtual ICollection<GroupFb> GroupFbs { get; set; } = new List<GroupFb>();

    public virtual ICollection<PageFb> PageFbs { get; set; } = new List<PageFb>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<UsersAccountFb> UsersAccountFbs { get; set; } = new List<UsersAccountFb>();
}
