using SmartBot.DataDto.Base;

namespace SmartBot.Services.Action
{
    public interface IActionsService
    {
        public ResponseBase GetActionHistory(string token, int currentPage, int itemsPerPage, string? startTime, string? endTime, int? idFb, int? actionId);
        public ResponseBase GetActionType();
        public ResponseBase GetLogActions(int idLogAction);
    }
}
