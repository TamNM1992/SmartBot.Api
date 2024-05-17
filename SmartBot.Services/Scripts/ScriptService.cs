
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
        private readonly ICommonRepository<Topic> _topicRepository;
        private readonly ICommonRepository<ContentTopic> _contentTopicRepository;

        private readonly ICommonRepository<ImagePath> _imgRepository;
        private readonly ICommonRepository<ContentFb> _contentRepository;
        private readonly ICommonRepository<AccountFb> _accountRepository;
        private readonly ICommonRepository<ClientCustomer> _clientRepository;
        private readonly ICommonRepository<UserClient> _userClientRepository;
        private readonly ICommonRepository<UsersAccountFb> _userAccountRepository;
        private readonly ICommonRepository<GroupFb> _groupRepository;
        private readonly ICommonRepository<FaceBookGroup> _fbgroupRepository;
        private readonly ICommonRepository<FaceBookPage> _fbpageRepository;

        private readonly ICommonRepository<Post> _postRepository;
        private readonly ICommonRepository<PostComment> _postCommentRepository;




        public ScriptService( IMapper mapper, ICommonUoW commonUoW, ICommonRepository<Script> scriptRepository, 
            ICommonRepository<Action> actionRepository,ICommonRepository<ContentFb> contentRepository,
            ICommonRepository<AccountFb> accountRepository, ICommonRepository<ClientCustomer> clientRepository,
            ICommonRepository<UserClient> userClientRepository, ICommonRepository<TypeAction> typeRepository, 
            ICommonRepository<ActionType> actionTypeRepository,ICommonRepository<UsersAccountFb> userAccountRepository, 
            ICommonRepository<Topic> topicRepository,ICommonRepository<ImagePath> imgRepository,
            ICommonRepository<GroupFb> groupRepository, ICommonRepository<FaceBookGroup> fbgroupRepository,
            ICommonRepository<Post> postRepository, ICommonRepository<PostComment> postCommentRepository,
            ICommonRepository<FaceBookPage> fbpageRepository, ICommonRepository<ContentTopic> contentTopicRepository)
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
            _topicRepository = topicRepository;
            _imgRepository = imgRepository;
            _groupRepository = groupRepository;
            _fbgroupRepository = fbgroupRepository;
            _postRepository = postRepository;
            _postCommentRepository = postCommentRepository;
            _fbpageRepository = fbpageRepository;
            _contentTopicRepository = contentTopicRepository;
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
        public ResponseBase GetContentByActionDetail(int idUser, int idAccountFB,string hardwareId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var content = _contentRepository.FindAll(x => x.IdFaceBook==idAccountFB)
                                                .Include(x => x.ContentTopics)
                                                .ThenInclude(y => y.IdTopicNavigation);

                var data = content.Select(x => new ContentScriptDto
                {
                    Id=x.Id,
                    Detail = x.Detail,
                    ListTopic = x.ContentTopics.Select(y => y.IdTopicNavigation.Topic1).ToList(),
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
        public ResponseBase GetTargetByActionDetail(int idUser, int idAccountFB,int typeAction)//0-all 1-acc 2-page 3-group
        {
            ResponseBase response = new ResponseBase();
            var data = new TargetScriptDto();
            try
            {
                if(typeAction==1||typeAction==0)
                {
                    data.ListAccount = new List<AccountTargetDto>();

                    var listacc = _userAccountRepository.FindAll(x=>x.IdUser==idUser)
                                                    .Include(x => x.IdAccountFbNavigation);
                    if(listacc.Any() )
                    {
                        data.ListAccount = listacc.Select(x=>x.IdAccountFbNavigation).Select(x=> new AccountTargetDto
                        {
                            Id = x.Id,
                            FbUser = x.FbUser,
                            FbProfileLink = x.FbProfileLink,
                            KeySearch = x.KeySearch,
                            Type = "Account"
                        }).ToList();
                        
                    }
                    
                }
                if (typeAction==2||typeAction==0)
                {
                    data.ListPage = new List<PageTargetDto>();
                    var listpage = _fbpageRepository.FindAll(x => x.IdFaceBook==idAccountFB)
                                                    .Include(x => x.IdPageFbNavigation);
                    if (listpage.Any())
                    {
                        data.ListPage = listpage.Select(x => x.IdPageFbNavigation).Select(y => new PageTargetDto
                        {
                            Id=y.Id,
                            Url = y.Url,
                            Name = y.Name,
                            Type = "Page"

                        }).ToList();
                        
                    }

                }
                if (typeAction==3||typeAction==0)
                {
                    data.ListGroup = new List<GroupTargetDto>();
                    var listgroup = _fbgroupRepository.FindAll(x=>x.IdFaceBook==idAccountFB)
                                                    .Include (x => x.IdGroupFbNavigation);
                    if(listgroup.Any() )
                    {
                        data.ListGroup = listgroup.Select(x=>x.IdGroupFbNavigation).Select(y=> new GroupTargetDto
                        {
                            Id=y.Id,
                            Url = y.Url,
                            Name = y.Name,
                            Type = "Group"
                        }).ToList() ;
                    }
                    
                }

                response.Data = data;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
        public ResponseBase GetContentById(int idContent, string hardwareId )
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var content = _contentRepository.GetById(idContent);
                if(content == null )
                {
                    response.Message = "Not existing";
                    return response;
                }
                var topics = _contentTopicRepository.FindAll(x=>x.IdContent==idContent).Include(x=>x.IdTopicNavigation);
                var img = new ImgDto();
                if(content.Img==true)
                {
                    var client = _clientRepository.FindSingle(x=>x.HardwareId==hardwareId);
                    img = _imgRepository.FindAll(x => x.IdContent==idContent&&x.IdClient==client.Id).Select(x=>new ImgDto
                    {
                        Id = x.Id,
                        Path = x.Path,
                    }).FirstOrDefault();
                }
                var data =new ContentScriptDto()
                {
                    Id=content.Id,
                    Detail = content.Detail,
                    ListTopic = (topics.Any()?topics.Select(x=>x.IdTopicNavigation.Topic1).ToList():new List<string>()),
                    Img =img,
                };

                response.Data = data;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
        public ResponseBase UpdateContent(UpdateContentParam param)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var content = _contentRepository.GetById(param.IdContent);
                content.Detail = param.Detail;
                content.DateUpdate = DateTime.Now;
                var img = _imgRepository.GetById(param.IdImg);
                img.Path  =param.PathImg;
                _commonUoW.BeginTransaction();
                _contentRepository.Update(content);
                _imgRepository.Update(img);
                _commonUoW.Commit();
                response.Data = "Success";
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
