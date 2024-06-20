using AutoMapper;
using SmartBot.Common.Enums;
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
            _mapper = mapper;
            _commonUoW = commonUoW;
            _userRepository = userRepository;
            _userAccountRepository = userAccountRepository;
            _accountRepository = accountRepository;
        }

        public ResponseBase GetActionHistory(int IdUser, DateTime? start, DateTime? end, int? IdFb, int? ActionId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                
                List<LogActionDto> logActions = new List<LogActionDto>()
                {
                    new LogActionDto
                    {
                        StartTime = DateTime.Parse("2024-06-19"),
                        EndTime = DateTime.Parse("2024-06-19"),
                        IdFb = 3,
                        Action = "Tha tim",
                        NameFb = "quanlhjos@gmail.com",
                        ResultDetail = "Thanh cong",
                        Result = true
                    },
                    new LogActionDto
                    {
                        StartTime = DateTime.Parse("2024-06-19"),
                        EndTime = DateTime.Parse("2024-06-19"),
                        IdFb = 4,
                        Action = "Tha tim",
                        NameFb = "0961082002",
                        ResultDetail = "That bai",
                        Result = false
                    }
                };
                response.Data = logActions;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
    }
}
