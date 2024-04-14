


using SmartBot.DataDto.Base;

namespace SmartBot.Services.ClassConfigFacebook
{
    public interface IClassConfigFacebookService
    {
        public ResponseBase GetCommentGroup();
        public ResponseBase GetCommentConfig();
        public ResponseBase GetUpImgConfig();

    }
}
