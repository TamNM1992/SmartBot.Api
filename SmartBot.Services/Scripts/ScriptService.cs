using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models.Security;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using NhaDat24h.Common.Enums;
using SmartBot.Common.Enums;
using SmartBot.Common.Extention;
using SmartBot.Common.Helpers;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Img;
using SmartBot.DataDto.Script;
using SmartBot.DataDto.User;
using System.Data;
using System.Net;
using Actions = SmartBot.DataAccess.Entities.Action;

namespace SmartBot.Services.Scripts
{
    public class ScriptService : IScriptService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<Script> _scriptRepository;
        private readonly ICommonRepository<Actions> _actionRepository;
        private readonly ICommonRepository<DataAccess.Entities.ActionType> _actionTypeRepository;
        private readonly ICommonRepository<Topic> _topicRepository;
        private readonly ICommonRepository<ContentTopic> _contentTopicRepository;

        private readonly ICommonRepository<ImagePath> _imgRepository;
        private readonly ICommonRepository<ContentFb> _contentRepository;
        private readonly ICommonRepository<AccountFb> _accountRepository;
        private readonly ICommonRepository<ClientCustomer> _clientRepository;
        private readonly ICommonRepository<User> _userRepository;
        private readonly ICommonRepository<UserClient> _userClientRepository;
        private readonly ICommonRepository<UsersAccountFb> _userAccountRepository;
        private readonly ICommonRepository<GroupFb> _groupRepository;

        private readonly ICommonRepository<Post> _postRepository;
        private readonly ICommonRepository<PostComment> _postCommentRepository;
        private readonly ICommonRepository<LogScript> _logScriptRepository;
        private readonly ICommonRepository<LogActionScript> _logActionRepository;
        private readonly ICommonRepository<LogStepAction> _logStepRepository;




        public ScriptService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<Script> scriptRepository,
            ICommonRepository<Actions> actionRepository, ICommonRepository<ContentFb> contentRepository,
            ICommonRepository<AccountFb> accountRepository, ICommonRepository<ClientCustomer> clientRepository,
            ICommonRepository<UserClient> userClientRepository, ICommonRepository<LogStepAction> logStepRepository,
            ICommonRepository<DataAccess.Entities.ActionType> actionTypeRepository, ICommonRepository<UsersAccountFb> userAccountRepository,
            ICommonRepository<Topic> topicRepository, ICommonRepository<ImagePath> imgRepository,
            ICommonRepository<GroupFb> groupRepository, ICommonRepository<Post> postRepository,
            ICommonRepository<PostComment> postCommentRepository, ICommonRepository<ContentTopic> contentTopicRepository,
            ICommonRepository<User> userRepository, ICommonRepository<LogActionScript> logActionRepository,
            ICommonRepository<LogScript> logScriptRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _scriptRepository = scriptRepository;
            _actionRepository = actionRepository;
            _contentRepository = contentRepository;
            _accountRepository = accountRepository;
            _clientRepository = clientRepository;
            _userClientRepository = userClientRepository;
            _actionTypeRepository = actionTypeRepository;
            _userAccountRepository = userAccountRepository;
            _topicRepository = topicRepository;
            _imgRepository = imgRepository;
            _groupRepository = groupRepository;
            _postRepository = postRepository;
            _postCommentRepository = postCommentRepository;
            _contentTopicRepository = contentTopicRepository;
            _userRepository = userRepository;
            _logActionRepository = logActionRepository;
            _logStepRepository = logStepRepository;
            _logScriptRepository = logScriptRepository;
        }
        public ResponseBase ImportScript(List<ScriptImportExcelDto> param)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var result = "";
                if(param == null || !param.Any()) { response.Message = "Data Empty"; }
                foreach (var script in param)
                {
                    var scriptIndex = 1;
                    var user = _userRepository.FindAll(x=>x.Id==script.IdUser).FirstOrDefault();
                    if(user == null)
                    {
                        result+=ErrorCodeMessage.UserNotExisting.Value;
                        response.Message = result;
                        return response;
                    }    
                    var client = _clientRepository.FindAll(x=>x.HardwareId == script.HwId).FirstOrDefault();
                    var clientId = 0;
                    if(client == null)
                    {
                        result +="CLient không tồn tại";
                        response.Message = result;
                        return response;
                    }    
                    var userCLient = _userClientRepository.FindAll(x=>x.IdUser==user.Id&&x.IdClient==client.Id).FirstOrDefault();
                    if (userCLient==null)
                    {
                        result+=" thông tin user hoặc thiết bị không đúng";
                        response.Message = result;
                        return response;
                    }
                    var newScript = new Script()
                    {
                        IdUserClient = userCLient.Id,
                        DateUpdate = DateTime.Now,
                        Status=1,
                        Name =script.Name,
                    };
                    try
                    {
                        _commonUoW.BeginTransaction();
                        _scriptRepository.Insert(newScript);
                        _commonUoW.Commit();
                    }
                    catch (Exception ex)
                    {
                        result+= $" Sheet {scriptIndex} lỗi.";
                        continue;
                    }
                    if(newScript.Id<=0)
                    {
                        result+= $" Sheet {scriptIndex} lỗi.";
                        continue;
                    }
                    var ListAction = new List<Actions>();
                    foreach(var action in script.ListAction)
                    {
                        var newAction = new Actions();
                        newAction.IdScript=newScript.Id;
                        newAction.SequenceNumber = action.SequenceNumber;
                        var account = _accountRepository.FindAll(x=>x.FbUser==action.Account).SingleOrDefault();
                        if(account==null)
                        {
                            var newFB = new AccountFb()
                            {
                                FbUser=action.Account,
                                FbPassword = action.Password,
                                FbProfileLink = "",
                                KeySearch = action.Account.ToLower(),
                                DateLogin = DateTime.Now,
                                Status = 1,
                            };
                            _commonUoW.BeginTransaction();
                            _accountRepository.Insert(newFB);
                            _commonUoW.Commit();
                            var newUserFB = new UsersAccountFb()
                            {
                                IdUser=script.IdUser,
                                IdAccountFb = newFB.Id,
                                Status = 1,
                                DateUpdate = DateTime.Now,
                            };
                            _commonUoW.BeginTransaction();
                            _userAccountRepository.Insert(newUserFB);
                            _commonUoW.Commit();
                            newAction.IdAccountFb = newFB.Id;
                        }
                        else
                        {
                            newAction.IdAccountFb = account.Id;
                            if(action.Password!=null)
                            {
                                account.FbPassword = action.Password;
                                _commonUoW.BeginTransaction();
                                _accountRepository.Update(account);
                                _commonUoW.Commit();
                            }    

                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
        public ResponseBase CreateScript(ScriptDto param)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var user = _userRepository.GetById(param.IdUser);
                if (user == null)
                {
                    response.Message = "User not existing";
                    response.Code = 99;
                    return response;
                }
                if (param.ListAction == null && !param.ListAction.Any())
                {
                    response.Message = "No action, invalid";
                    response.Code = 98;
                    return response;
                }
                var client = _clientRepository.FindAll(x => x.HardwareId == param.HardwareId).SingleOrDefault();
                var clientid = 0;
                if (client == null)
                {
                    var newclient = new ClientCustomer()
                    {
                        HardwareId = param.HardwareId,
                        DateUpdate = DateTime.UtcNow,
                    };
                    _commonUoW.BeginTransaction();
                    _clientRepository.Insert(newclient);
                    _commonUoW.Commit();
                    clientid = newclient.Id;
                }
                else
                {
                    clientid = client.Id;
                }
                var userclient = _userClientRepository.FindAll(x => x.IdUser == user.Id && x.IdClient == clientid).SingleOrDefault();
                var userclientId = 0;
                if (userclient == null)
                {
                    var newUserClient = new UserClient()
                    {
                        IdUser = user.Id,
                        IdClient = clientid,
                    };
                    _commonUoW.BeginTransaction();
                    _userClientRepository.Insert(newUserClient);
                    _commonUoW.Commit();
                    userclientId = newUserClient.Id;
                }
                else
                {
                    userclientId = userclient.Id;
                }
                var script = new Script()
                {
                    Name = param.Name,
                    IdUserClient = userclientId,
                    DateUpdate = DateTime.UtcNow,
                    Status = 0,
                };

                _commonUoW.BeginTransaction();
                _scriptRepository.Insert(script);
                _commonUoW.Commit();
                var idScript = script.Id;
                var listAction = param.ListAction.Select(x => new Actions
                {
                    IdScript = idScript,
                    IdAccountFb = x.IdAccountFb,
                    Style = x.Style,
                    SequenceNumber = x.SequenceNumber,
                    IdContent = x.IdContent,
                    StepNumber = x.IdTarget,
                    TypeTarget = x.TypeTarget,
                    DateUpdate = DateTime.UtcNow,
                });
                _commonUoW.BeginTransaction();
                _actionRepository.InsertMultiple(listAction);
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
        public ResponseBase GetScriptByUserClient(int idUser, string hardwareId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var client = _clientRepository.FindAll(x => x.HardwareId == hardwareId).SingleOrDefault();
                var userClient = _userClientRepository.FindAll(x => x.IdUser == idUser && x.IdClient == client.Id).SingleOrDefault();
                
                var script = _scriptRepository.FindAll()
                                              .Include(x => x.Actions).ThenInclude(x => x.IdAccountFbNavigation)
                                              .Include(x => x.Actions).ThenInclude(x => x.IdContentNavigation);

                if (script == null)
                {
                    response.Message = "Chưa có kịch bản , hãy tạo trước nhé";
                    response.Code = 99;
                    return response;
                }
                var data = script.Select(x => new ScriptDataDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    ListActions = x.Actions.Select(y => new ActionDataDto
                    {
                        Id = y.Id,
                        Account = new AccountFbDto()
                        {
                            IdFb = y.IdAccountFbNavigation.Id,
                            UserName = y.IdAccountFbNavigation.FbUser,
                            Password = y.IdAccountFbNavigation.FbPassword,
                        },
                        Style = y.Style,
                        Link = y.Link,
                        SequenceNumber = y.SequenceNumber,
                        NumberGet = y.NumberGet,
                        KeyWord = y.KeyWord,
                        Content = (y.IdContent > 0) ? new ContentDataDto()
                        {
                            Id = y.IdContentNavigation.Id,
                            Detail = y.IdContentNavigation.Detail,
                            Type = (byte)y.IdContentNavigation.Type,
                        } : null,
                        Target = new TargetDataDto()
                        {
                            Type = y.TypeTarget,
                            IdTarget = y.StepNumber,
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
                var listacc = _userAccountRepository.FindAll(x => x.IdUser == idUser)
                                                    .Include(x => x.IdAccountFbNavigation);
                if (listacc == null)
                {
                    response.Message = "List acc null";
                    return response;
                }
                var data = listacc.Select(x => new AccountDataDto
                {
                    Id = x.IdAccountFbNavigation.Id,
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
        public ResponseBase GetContentByActionDetail(int idUser, int idAccountFB, string hardwareId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var content = _contentRepository.FindAll(x => x.IdFaceBook == idAccountFB)
                                                .Include(x => x.ContentTopics)
                                                .ThenInclude(y => y.IdTopicNavigation);

                var data = content.Select(x => new ContentScriptDto
                {
                    Id = x.Id,
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
        public ResponseBase GetTargetByActionDetail(int idUser, int idAccountFB, int typeAction)//0-all 1-acc 2-page 3-group
        {
            ResponseBase response = new ResponseBase();
            var data = new TargetScriptDto();
            try
            {
                if (typeAction == 1 || typeAction == 0)
                {
                    data.ListAccount = new List<AccountTargetDto>();

                    var listacc = _userAccountRepository.FindAll(x => x.IdUser == idUser)
                                                    .Include(x => x.IdAccountFbNavigation);
                    if (listacc.Any())
                    {
                        data.ListAccount = listacc.Select(x => x.IdAccountFbNavigation).Select(x => new AccountTargetDto
                        {
                            Id = x.Id,
                            FbUser = x.FbUser,
                            FbProfileLink = x.FbProfileLink,
                            KeySearch = x.KeySearch,
                            Type = "Account"
                        }).ToList();

                    }

                }
                if (typeAction == 2 || typeAction == 0)
                {
                    data.ListPage = new List<PageTargetDto>();
                    //var listpage = _fbpageRepository.FindAll(x => x.IdFaceBook==idAccountFB)
                    //                                .Include(x => x.IdPageFbNavigation);
                    //if (listpage.Any())
                    //{
                    //    data.ListPage = listpage.Select(x => x.IdPageFbNavigation).Select(y => new PageTargetDto
                    //    {
                    //        Id=y.Id,
                    //        Url = y.Url,
                    //        Name = y.Name,
                    //        Type = "Page"

                    //    }).ToList();

                    //}

                }
                if (typeAction == 3 || typeAction == 0)
                {
                    data.ListGroup = new List<GroupTargetDto>();
                    //var listgroup = _fbgroupRepository.FindAll(x=>x.IdFaceBook==idAccountFB)
                    //                                .Include (x => x.IdGroupFbNavigation);
                    //if(listgroup.Any() )
                    //{
                    //    data.ListGroup = listgroup.Select(x=>x.IdGroupFbNavigation).Select(y=> new GroupTargetDto
                    //    {
                    //        Id=y.Id,
                    //        Url = y.Url,
                    //        Name = y.Name,
                    //        Type = "Group"
                    //    }).ToList() ;
                    //}

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
        public ResponseBase GetContentById(int idContent, string hardwareId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var content = _contentRepository.GetById(idContent);
                if (content == null)
                {
                    response.Message = "Not existing";
                    return response;
                }
                var topics = _contentTopicRepository.FindAll(x => x.IdContent == idContent).Include(x => x.IdTopicNavigation);
                var img = new ImgDto();
                if (content.Img == true)
                {
                    var client = _clientRepository.FindSingle(x => x.HardwareId == hardwareId);
                    img = _imgRepository.FindAll(x => x.IdContent == idContent && x.IdClient == client.Id).Select(x => new ImgDto
                    {
                        Id = x.Id,
                        Path = x.Path,
                    }).FirstOrDefault();
                }
                var data = new ContentScriptDto()
                {
                    Id = content.Id,
                    Detail = content.Detail,
                    ListTopic = (topics.Any() ? topics.Select(x => x.IdTopicNavigation.Topic1).ToList() : new List<string>()),
                    Img = img,
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
        public ResponseBase GetPostTarget(int idTarget, int typeTarget)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = new List<PostInTargetDto>();
                var post = _postRepository.FindAll(x => ((typeTarget == 1) ? x.IdAccount == idTarget : (typeTarget == 2) ? x.IdPage == idTarget : x.IdGroup == idTarget));
                if (post != null && post.Any())
                {
                    data = post.Select(x => new PostInTargetDto
                    {
                        Id = x.Id,
                        Content = x.Content,
                        Url = x.Url,
                        Type = typeTarget,
                    }).ToList();
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
        public ResponseBase GetPostById(int idPost)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var post = _postRepository.GetById(idPost);
                if (post == null)
                {
                    response.Message = "Not existing";
                    return response;
                }
                var data = new PostDetailDto
                {
                    Id = post.Id,
                    Content = post.Content,
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
                var client = _clientRepository.FindAll(x => x.HardwareId == param.HwId).FirstOrDefault();
                var clientId = 0;
                if (client == null)
                {
                    var newclient = new ClientCustomer()
                    {
                        HardwareId = param.HwId,
                        DateUpdate = DateTime.Now,
                    };
                    _commonUoW.BeginTransaction();
                    _clientRepository.Insert(newclient);
                    _commonUoW.Commit();
                    clientId = newclient.Id;
                }
                else
                {
                    clientId = client.Id;
                }
                var content = _contentRepository.GetById(param.IdContent);
                content.Detail = param.Detail;
                content.DateUpdate = DateTime.Now;
                if (param.PathImg != null && param.PathImg.Any())
                {
                    content.Img = true;
                    if (param.IdImg > 0)
                    {
                        var img = _imgRepository.GetById(param.IdImg);
                        img.Path = param.PathImg;
                        _commonUoW.BeginTransaction();
                        _imgRepository.Update(img);
                        _commonUoW.Commit();
                    }
                    else
                    {
                        var newimg = new ImagePath()
                        {
                            IdClient = clientId,
                            IdContent = param.IdContent,
                            Path = param.PathImg,
                        };
                        _commonUoW.BeginTransaction();
                        _imgRepository.Insert(newimg);
                        _commonUoW.Commit();
                    }
                }
                else
                {
                    content.Img = false;
                    if (param.IdImg > 0)
                    {
                        var img = _imgRepository.GetById(param.IdImg);
                        _commonUoW.BeginTransaction();
                        _imgRepository.Remove(img);
                        _commonUoW.Commit();
                    }
                }
                _commonUoW.BeginTransaction();
                _contentRepository.Update(content);
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
        public ResponseBase LogScript(LogScriptInputData param)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                string datalog = JsonConvert.SerializeObject(param);
                FileHelper.WriteFile("D:/LogScript" + $"/{param.IdScript}/{DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")}", datalog);
                var client = _clientRepository.FindAll(x => x.HardwareId == param.HardwareId).FirstOrDefault();
                if (client == null)
                {
                    response.Message = "Client không tồn tại";
                    return response;
                }
                var logScript = new LogScript
                {
                    StartTime = param.StartTime,
                    EndTime = param.EndTime,
                    IdScript = param.IdScript,
                    IdUser = param.IdUser,
                    IdClient = client.Id,
                };
                _commonUoW.BeginTransaction();
                _logScriptRepository.Insert(logScript);
                _commonUoW.Commit();
                if (logScript.Id <= 0)
                {
                    response.Message = "Insert fail";
                    return response;
                }
                foreach (var action in param.ListActionResult)
                {
                    var a = new LogActionScript();
                    a.Name = action.Name;
                    a.Description = action.Description;
                    a.StartTime = action.Start;
                    a.EndTime = action.End;
                    a.IdFb = action.IdFB;
                    a.NameFb = action.NameFB;
                    a.Result = action.Result;
                    a.IdLogScript = logScript.Id;
                    a.ResultDetail = action.ResultDetail;
                    a.IdScript = param.IdScript;
                    a.Style = action.Style;
                    _commonUoW.BeginTransaction();
                    _logActionRepository.Insert(a);
                    _commonUoW.Commit();
                    if (a.Id <= 0)
                    {
                        continue;
                    }
                    var listStep = new List<LogStepAction>();
                    foreach (var step in action.ListStep)
                    {
                        var s = new LogStepAction();
                        s.IdLogAction = a.Id;
                        s.StepDetail = step;
                        s.Result = true;
                        listStep.Add(s);
                    }
                    _commonUoW.BeginTransaction();
                    _logStepRepository.InsertMultiple(listStep);
                    _commonUoW.Commit();
                }
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
