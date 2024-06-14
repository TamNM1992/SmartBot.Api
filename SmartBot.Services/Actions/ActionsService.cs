using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Action;
using SmartBot.DataDto.Base;
using User = SmartBot.DataAccess.Entities.User;

namespace SmartBot.Services.Action
{
    public class ActionsService : IActionsService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;

        private readonly ICommonRepository<DataAccess.Entities.User> _userRepository;
        private readonly ICommonRepository<UsersAccountFb> _userAccountRepository;
        private readonly ICommonRepository<AccountFb> _accountRepository;

        public ActionsService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<User> userRepository, ICommonRepository<UsersAccountFb> userAccountRepository, ICommonRepository<AccountFb> accountRepository)
        {
            _mapper=mapper;
            _commonUoW=commonUoW;
            _userRepository=userRepository;
            _userAccountRepository=userAccountRepository;
            _accountRepository=accountRepository;
        }

        public ResponseBase GetActionHistory(int IdUser, DateTime? start, DateTime? end)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var getFbUser = _userAccountRepository.FindAll(x => x.IdUser == IdUser)
                    .Include(y => y.IdAccountFbNavigation)
                    .ThenInclude(z => z.Actions);
                List<ActionHistory> listHistory = new List<ActionHistory>();
                foreach (var item in getFbUser)
                {
                    List<DataAccess.Entities.Action> listAction = item.IdAccountFbNavigation.Actions.OrderByDescending(a => a.DateUpdate).ToList();
                    if (start.HasValue && end.HasValue)
                    {
                        listAction = listAction.Where(a => a.DateUpdate >= start && a.DateUpdate <= end).ToList();
                    }
                    ActionHistory actionHistory = new ActionHistory()
                    {
                        FbUser = item.IdAccountFbNavigation.FbUser,
                        ActionName = listAction.Select(x => x.Style).ToList(),
                        Result= true,
                        StartTime= listAction.Select(x => x.DateUpdate).ToList(),
                        ExcuteTime= listAction.Select(x => x.DateUpdate).ToList(),
                    };
                    listHistory.Add(actionHistory);
                }
                response.Data = listHistory;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
    }
}
