using SmartBot.DataDto.Base;

namespace SmartBot.Services.Action
{
    public interface IActionsService
    {
        public ResponseBase GetActionHistory(string token, DateTime? start, DateTime? end, int? idFb, int? actionId);
    }
}
