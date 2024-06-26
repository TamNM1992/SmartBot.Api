using AutoMapper;
using SmartBot.Common.Enums;
using SmartBot.Common.Helpers;
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

        public ResponseBase GetActionHistory(string token, DateTime? start, DateTime? end, int? idFb, int? actionId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                // Tượng trưng cho bảng Actions
                Dictionary<int, string> actions = new Dictionary<int, string>();
                actions.Add(1, "Thích");
                actions.Add(2, "Bình luận");
                actions.Add(3, "Đăng bài");
                actions.Add(4, "Chia sẻ");
                actions.Add(5, "Thả tim");

                // Tượng trưng cho bảng LogActions
                List<LogActionDto> logActions = new List<LogActionDto>()
                {
                    new LogActionDto
                    {
                        IdUser = 2,
                        StartTime = DateTime.Parse("2024-06-19"),
                        EndTime = DateTime.Parse("2024-06-19"),
                        IdFb = 3,
                        Action = actions[1],
                        NameFb = "quanlhjos@gmail.com",
                        ResultDetail = "Thành công",
                        Result = true
                    },
                    new LogActionDto
                    {
                        IdUser = 2,
                        StartTime = DateTime.Parse("2024-06-19"),
                        EndTime = DateTime.Parse("2024-06-19"),
                        IdFb = 4,
                        Action = actions[4],
                        NameFb = "0961082002",
                        ResultDetail = "Thất bại",
                        Result = false
                    },
                    new LogActionDto
                    {
                        IdUser = 11,
                        StartTime = DateTime.Parse("2024-07-20"),
                        EndTime = DateTime.Parse("2024-07-20"),
                        IdFb = 4,
                        Action = actions[5],
                        NameFb = "0961082002",
                        ResultDetail = "Thất bại",
                        Result = false
                    }
                };

                var idUser = int.Parse(Token.Authentication(token));
                var data = logActions.Where(log =>
                           log.IdUser == idUser &&
                           (!start.HasValue || log.StartTime >= start.Value) &&
                           (!end.HasValue || log.EndTime <= end.Value) &&
                           (!idFb.HasValue || log.IdFb == idFb) &&
                           (!actionId.HasValue || log.Action == actions[(int)actionId])).ToList();

                response.Data = data;
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
