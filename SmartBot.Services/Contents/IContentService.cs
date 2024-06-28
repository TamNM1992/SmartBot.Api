using SmartBot.DataDto.Base;
using SmartBot.DataDto.Contents;

namespace SmartBot.Services.Content
{
    public interface IContentService
    {
        public ResponseBase GetListContentByType(int idUser, string hwId, byte type);
        public ResponseBase InsertDefaultContent(CreateNewContentParam param);
        public ResponseBase GetContentById(int idContent, string hwId);
        public ResponseBase GetMultiContentById(string idContents, string hwId);

    }
}
