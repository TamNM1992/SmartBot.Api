
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Script;

namespace SmartBot.Services.Scripts
{
    public interface IScriptService
    {
        public ResponseBase GetScriptByUserClient(int idUser, string hardwareId);
        public ResponseBase GetListAccountForScript(int idUser);
        ResponseBase GetContentByActionDetail(int idUser, int idAccountFB, string hardwareId);
        public ResponseBase GetTargetByActionDetail(int idUser, int idAccountFB, int typeAction);
        public ResponseBase GetContentById(int idContent, string hardwareId);
        public ResponseBase UpdateContent(UpdateContentParam param);
        public ResponseBase GetPostTarget(int idTarget, int typeTarget);

    }
}
