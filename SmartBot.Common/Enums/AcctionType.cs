
using System.ComponentModel;

namespace SmartBot.Common.Enums
{
    public enum ActionBasicType
    {
        [Description("Post")]
        Post = 1,
        [Description("Like")]
        Like = 2,
        [Description("Share")]
        Share = 3,
        [Description("Comment")]
        Comment = 4,
        [Description("Search")]
        Search = 5,
    }
    public enum ActionDetailType
    {
        [Description("PostWall")]
        PostWall = 1,
        [Description("PostGroup")]
        PostGroup = 2,
        [Description("Like")]
        Like = 3,
        [Description("Heart")]
        Heart = 4,
        [Description("HugHeart")]
        HugHeart = 5,
        [Description("Laugh")]
        Laugh = 6,
        [Description("Wow")]
        Wow = 7,
        [Description("Sad")]
        Sad = 8,
        [Description("Angry")]
        Angry = 9,
        [Description("ShareWall")]
        ShareWall = 10,
        [Description("ShareGroup")]
        ShareGroup = 11,
        [Description("CommentPost")]
        CommentPost = 12,
        [Description("RepComment")]
        RepComment = 13,
        [Description("SearchGroup")]
        SearchGroup = 14,
        [Description("SearchPage")]
        SearchPage = 15,
        [Description("GetPostWall")]
        GetPostWall = 30,
        [Description("GetPostGroup")]
        GetPostGroup = 31,
        [Description("LoginFanpage")]
        LoginFanpage = 17,
        [Description("SwitchMain")]
        SwitchMain = 18,
        [Description("ChangeAvatar")]
        ChangeAvatar = 90,
        [Description("ChangeCover")]
        ChangeCover = 91,
        [Description("SendFriendRequest")]
        SendFriendRequest = 92,
        [Description("AcceptFriendRequest")]
        AcceptFriendRequest = 93,
    }
    public enum ActionType
    {
        [Description("Post")]
        Post = 1,
        [Description("Comment")]
        Comment = 2,
        [Description("CommentToNewPost")]
        CommentToNewPost = 3,
        [Description("Share")]
        Share = 4,
        [Description("Like")]
        Like = 5,
        [Description("Search")]
        Search = 6,
        [Description("RepComment")]
        RepComment = 7,
        [Description("Heart")]
        Heart = 51,
        [Description("HugHeart")]
        HugHeart = 52,
        [Description("Laugh")]
        Laugh = 53,
        [Description("Wow")]
        Wow = 54,
        [Description("Sad")]
        Sad = 55,
        [Description("Angry")]
        Angry = 56,

    }
    public enum ContentType
    {
        [Description("PostWallNoImg")]
        PostWallNoImg = 1,
        [Description("PostWallHasImg")]
        PostWallHasImg = 2,

        [Description("CommentNoImg")]
        CommentNoImg = 3,
        [Description("CommentHasImg")]
        CommentHasImg = 4
    }
}
