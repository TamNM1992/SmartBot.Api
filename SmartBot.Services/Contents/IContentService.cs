using SmartBot.DataDto.Base;

namespace SmartBot.Services.Content
{
    public interface IContentService
    {
        public ResponseBase GetListContentByType(int idUser, string hwId, byte type);

    }
}
