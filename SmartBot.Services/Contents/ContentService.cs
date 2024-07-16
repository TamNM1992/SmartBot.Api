
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Contents;
using SmartBot.DataDto.Img;
using static System.Net.Mime.MediaTypeNames;

namespace SmartBot.Services.Content
{
    public class ContentService : IContentService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<ContentFb> _contentRepository;
        private readonly ICommonRepository<AccountFb> _accFbRepository;
        private readonly ICommonRepository<UsersAccountFb> _userAccfbRepository;
        private readonly ICommonRepository<ClientCustomer> _clientRepository;
        private readonly ICommonRepository<UserClient> _userclientRepository;
        private readonly ICommonRepository<ImagePath> _imgRepository;




        public ContentService( IMapper mapper, ICommonUoW commonUoW, ICommonRepository<ContentFb> contentRepository,
            ICommonRepository<AccountFb> accFbRepository, ICommonRepository<UsersAccountFb> userAccfbRepository,
            ICommonRepository<ClientCustomer> clientRepository, ICommonRepository<UserClient> userclientRepository,
            ICommonRepository<ImagePath> imgRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _contentRepository = contentRepository;
            _accFbRepository = accFbRepository;
            _userAccfbRepository= userAccfbRepository;
            _clientRepository = clientRepository;
            _userclientRepository=userclientRepository;
            _imgRepository=imgRepository;
        }
        public ResponseBase GetListContentByType(int idUser, string hwId,byte type)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = new List<ContentDto>();
                var client = _clientRepository.FindAll(x=>x.HardwareId==hwId).SingleOrDefault();
                int idclient = 0;
                if (client != null)
                {
                    idclient = client.Id;
                }
                var listAcc = _userAccfbRepository.FindAll(x => x.IdUser==idUser).Select(x=>x.IdAccountFb);
                var contents = _contentRepository.FindAll(x => listAcc.Contains(x.IdFaceBook)&&((type==0)?x.Id>0:x.Type==type) )
                                                 .Include(x=>x.ImagePaths.Where(y=>y.IdClient==idclient));
                if(contents.Any() )
                {
                    data = contents.Select(x => new ContentDto
                    {
                        Id = x.Id,
                        Detail = x.Detail,
                        ListImg = (x.Img==true) ? x.ImagePaths.Select(y=> new ImgDto
                        {
                            Id= y.Id,
                            Path = y.Path,
                        }).ToList(): null,
                    }).ToList();
                }
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
        public ResponseBase InsertDefaultContent(CreateNewContentParam param)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var fbuser = _userAccfbRepository.FindAll(x=>x.IdUser==param.IdUser).FirstOrDefault();
                if(fbuser==null)
                {
                    response.Message = "Chưa có tài khoản FB nào, hãy đăng nhập 1 tài khoản FB trước";
                    return response;
                }
                var clientId = _clientRepository.FindAll(x=>x.HardwareId==param.HwId).SingleOrDefault().Id;

                var newContent = new ContentFb
                {
                    IdFaceBook = fbuser.IdAccountFb,
                    Detail = param.Detail,
                    DateUpdate = DateTime.Now,
                    Type = param.TypeContent,
                    Img = (param.ImgPath!=null && param.ImgPath.Any()) ? true : false,
                };
                _commonUoW.BeginTransaction();
                _contentRepository.Insert(newContent);
                _commonUoW.Commit();
                if(newContent.Img==true)
                {
                    var newimg = new ImagePath
                    {
                        IdClient = clientId,
                        IdContent = newContent.Id,
                        Path = param.ImgPath,
                    };
                    _commonUoW.BeginTransaction();
                    _imgRepository.Insert(newimg);
                    _commonUoW.Commit();
                }    

                response.Data = "Success";
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
        public ResponseBase GetContentById(int idContent, string hwId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = new ContentDto();
                var client = _clientRepository.FindAll(x=>x.HardwareId == hwId).SingleOrDefault();
                var content = _contentRepository.GetById(idContent);
                data.Id = content.Id;
                data.Detail = content.Detail;
                if(content.Img==true)
                {
                    var listimg = _imgRepository.FindAll(x => x.IdContent == idContent&&x.IdClient==client.Id);
                    if (listimg!=null && listimg.Any())
                    {
                        data.ListImg = _imgRepository.FindAll(x => x.IdContent == idContent&&x.IdClient==client.Id)
                                                    .Select(x => new ImgDto
                                                    {
                                                        Id = x.Id,
                                                        Path = x.Path,
                                                    }).ToList();
                    }
                }    
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
        public ResponseBase GetMultiContentById(string idContents, string hwId)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var listid = idContents.Split(',').Select(x=> int.Parse(x)).ToList();
                var data = new List<ContentDto>();
                var client = _clientRepository.FindAll(x => x.HardwareId == hwId).SingleOrDefault();
                var contents = _contentRepository.FindAll(x=> listid.Contains(x.Id)).Include(x=>x.ImagePaths);

                data = contents.Select(x=> new ContentDto
                {
                    Id= x.Id,
                    Detail=x.Detail,
                    ListImg = (x.Img==true)?x.ImagePaths.Where(y=>y.IdClient==client.Id).Select(x => new ImgDto
                    {
                        Id = x.Id,
                        Path = x.Path,
                    }).ToList(): new List<ImgDto>()
                }).ToList();
                
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
