
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models.Security;
using Microsoft.IdentityModel.Tokens;
using NhaDat24h.Common.Enums;
using SmartBot.Common.Extention;
using SmartBot.Common.Helpers;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Script;
using System.Data;
using Action = SmartBot.DataAccess.Entities.Action;

namespace SmartBot.Services.Scripts
{
    public class ScriptService : IScriptService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<Script> _scriptRepository;
        private readonly ICommonRepository<Action> _actionRepository;
        private readonly ICommonRepository<TypeAction> _typeRepository;
        private readonly ICommonRepository<ActionType> _actionTypeRepository;

        private readonly ICommonRepository<ContentFb> _contentRepository;
        private readonly ICommonRepository<AccountFb> _accountRepository;
        private readonly ICommonRepository<ClientCustomer> _clientRepository;
        private readonly ICommonRepository<UserClient> _userClientRepository;
        private readonly ICommonRepository<UsersAccountFb> _userAccountRepository;




        public ScriptService( IMapper mapper, ICommonUoW commonUoW, ICommonRepository<Script> scriptRepository, ICommonRepository<Action> actionRepository,
            ICommonRepository<ContentFb> contentRepository, ICommonRepository<AccountFb> accountRepository, ICommonRepository<ClientCustomer> clientRepository,
            ICommonRepository<UserClient> userClientRepository, ICommonRepository<TypeAction> typeRepository, ICommonRepository<ActionType> actionTypeRepository,
            ICommonRepository<UsersAccountFb> userAccountRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _scriptRepository = scriptRepository;
            _actionRepository = actionRepository;
            _contentRepository = contentRepository;
            _accountRepository = accountRepository;
            _clientRepository = clientRepository;
            _userClientRepository = userClientRepository;
            _typeRepository = typeRepository;
            _actionTypeRepository = actionTypeRepository;
            _userAccountRepository = userAccountRepository;

        }
        public ResponseBase GetScriptByUserClient(int idUser, string hardwareId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var client = _clientRepository.FindAll(x=>x.HardwareId == hardwareId).SingleOrDefault();
                var userClient = _userClientRepository.FindAll(x=>x.IdUser == idUser&&x.IdClient == client.Id).SingleOrDefault();
                var script = _scriptRepository.FindAll(x => x.IdUserClient == userClient.Id)
                                              .Include(x => x.Actions).ThenInclude(x => x.IdAccountFbNavigation)
                                              .Include(x => x.Actions).ThenInclude(x => x.IdContentNavigation)
                                              .Include(x => x.Actions).ThenInclude(x => x.ActionTypes);

                if (script==null)
                {
                    response.Message = "Chưa có kịch bản , hãy tạo trước nhé";
                    response.Code=99;
                    return response;
                }    
                var data = script.Select(x=> new ScriptDataDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    ListActions = x.Actions.Select(y=> new ActionDataDto
                    {
                        Id=y.Id,
                        Account = new AccountDataDto()
                        {
                            Id = y.IdAccountFbNavigation.Id,
                            FbUser = y.IdAccountFbNavigation.FbUser,
                            FbPassword = y.IdAccountFbNavigation.FbPassword,
                            FbProfileLink = y.IdAccountFbNavigation.FbProfileLink,
                        },
                        Link = y.Link,
                        Style = y.Style,
                        ListType = y.ActionTypes.Select(z=>z.IdType).ToList(),
                        SequenceNumber = y.SequenceNumber,
                        Content = new ContentDataDto()
                        {
                            Id = y.IdContentNavigation.Id,
                            Detail = y.IdContentNavigation.Detail,
                            Type = (byte)y.IdContentNavigation.Type,
                        }
                    }).ToList()
                }).ToList();
                response.Data = data;

                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
        public ResponseBase GetListAccountForScript(int idUser)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var listacc = _userAccountRepository.FindAll(x=>x.IdUser==idUser)
                                                    .Include(x=>x.IdAccountFbNavigation);
                if(listacc == null)
                {
                    response.Message = "List acc null";
                    return response;
                }
                var data = listacc.Select(x => new AccountDataDto
                {
                    Id=x.IdAccountFbNavigation.Id,
                    FbUser = x.IdAccountFbNavigation.FbUser,
                    FbPassword = x.IdAccountFbNavigation.FbPassword,
                    FbProfileLink = x.IdAccountFbNavigation.FbProfileLink,

                }).ToList();
                response.Data = data;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
        public ResponseBase GetContentByActionDetail(int idUser,int type, int idAccountFB,string hardwareId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var content = _contentRepository.FindAll(x => x.IdFaceBook==idAccountFB )
                                                .Include(x => x.ContentTopics)
                                                .ThenInclude(y=>y.IdTopicNavigation)
                                                .ThenInclude(z=>z.ImageTopics);
                var data = content.Select(x=> new ContentScriptDto
                {
                    Id=x.Id,
                    Detail = x.Detail,
                    ListImgPath = x.ContentTopics.Where(y=>y.IdTopic==1).Select(y=>y.IdTopicNavigation.ImageTopics).Select(z=>z.).ToList(),
                })
                if (listacc == null)
                {
                    response.Message = "List acc null";
                    return response;
                }
                var data = listacc.Select(x => new AccountDataDto
                {
                    Id=x.IdAccountFbNavigation.Id,
                    FbUser = x.IdAccountFbNavigation.FbUser,
                    FbPassword = x.IdAccountFbNavigation.FbPassword,
                    FbProfileLink = x.IdAccountFbNavigation.FbProfileLink,

                }).ToList();
                response.Data = data;
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
