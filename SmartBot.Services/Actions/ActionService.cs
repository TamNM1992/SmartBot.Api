using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Action;
using SmartBot.DataDto.Base;
using User = SmartBot.DataAccess.Entities.User;

namespace SmartBot.Services.Action
{
    public class ActionService : IActionService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;

        private readonly ICommonRepository<DataAccess.Entities.User> _userRepository;
        private readonly ICommonRepository<UsersAccountFb> _userAccountRepository;
        private readonly ICommonRepository<AccountFb> _accountRepository;

        public ActionService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<User> userRepository, ICommonRepository<UsersAccountFb> userAccountRepository, ICommonRepository<AccountFb> accountRepository)
        {
            _mapper=mapper;
            _commonUoW=commonUoW;
            _userRepository=userRepository;
            _userAccountRepository=userAccountRepository;
            _accountRepository=accountRepository;
        }

        public ResponseBase GetActionHistory(int IdUser)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var getFbUser = _userAccountRepository.FindAll(x => x.IdUser == IdUser)
                    .Include(y => y.IdAccountFbNavigation)
                    .ThenInclude(z => z.Actions);
                List<ActionHistory> listAction = new List<ActionHistory>();
                foreach (var item in getFbUser)
                {
                    ActionHistory actionHistory = new ActionHistory()
                    {
                        FbUser = item.IdAccountFbNavigation.FbUser,
                        ActionName = item.IdAccountFbNavigation.Actions.Select(x => x.Style).ToList(),
                        Result= true,
                        StartTime= item.IdAccountFbNavigation.Actions.Select(x => x.DateUpdate).ToList(),
                        ExcuteTime= item.IdAccountFbNavigation.Actions.Select(x => x.DateUpdate).ToList(),
                    };
                    listAction.Add(actionHistory);
                }
                response.Data = listAction;
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
