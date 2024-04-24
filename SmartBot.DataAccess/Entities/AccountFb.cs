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

    public virtual ICollection<CommentFb> CommentFbs { get; set; } = new List<CommentFb>();

    public virtual ICollection<FaceBookGroup> FaceBookGroups { get; set; } = new List<FaceBookGroup>();

    public virtual ICollection<FaceBookPage> FaceBookPages { get; set; } = new List<FaceBookPage>();

    public virtual ICollection<PostFb> PostFbs { get; set; } = new List<PostFb>();
}
