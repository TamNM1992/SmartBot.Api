using SmartBot.DataDto.Base;

namespace SmartBot.Services.Action
{
    public interface IActionsService
    {
        public ResponseBase GetActionHistory(string token, DateTime? start, DateTime? end, int? idFb, string? actionName);
        public ResponseBase GetActionType();
        public ResponseBase GetLogActions(int idLogAction);
    }
}
