
using SmartBot.DataDto.Base;

namespace SmartBot.Services.Scripts
{
    public interface IScriptService
    {
        public ResponseBase GetScriptByUserClient(int idUser, string hardwareId);
        public ResponseBase GetListAccountForScript(int idUser);

    }
}
