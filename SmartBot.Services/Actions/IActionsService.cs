using SmartBot.DataDto.Base;

namespace SmartBot.Services.Action
{
    public interface IActionsService
    {
        public ResponseBase GetActionHistory(int IdUser, DateTime? start, DateTime? end, int? IdFb, int? ActionId);
    }
}
