
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Contents;
using SmartBot.DataDto.Img;
using static System.Net.Mime.MediaTypeNames;
using User = SmartBot.DataAccess.Entities.User;

namespace SmartBot.Services.Content
{
    public class ContentService : IContentService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<ContentFb> _contentRepository;
        private readonly ICommonRepository<AccountFb> _accFbRepository;
        private readonly ICommonRepository<UsersAccountFb> _userAccfbRepository;
        private readonly ICommonRepository<ImagePath> _imgRepository;
        private readonly ICommonRepository<User> _userRepository;




        public ContentService( IMapper mapper, ICommonUoW commonUoW, ICommonRepository<ContentFb> contentRepository,
            ICommonRepository<AccountFb> accFbRepository, ICommonRepository<UsersAccountFb> userAccfbRepository,
            ICommonRepository<ImagePath> imgRepository, ICommonRepository<User> userRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _contentRepository = contentRepository;
            _accFbRepository = accFbRepository;
            _userAccfbRepository= userAccfbRepository;
            _imgRepository=imgRepository;
            _userRepository=userRepository;
        }
        public ResponseBase GetListContentByType(int idUser, string hwId,byte type)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var user = _userRepository.FindAll(x=>x.Id==idUser&&x.HardwareId==hwId).FirstOrDefault();
                if(user == null)
                {
                    response.Message="Thông tin user không hợp lệ";
                    return response;
                }
                var data = new List<ContentDto>();

                var listAcc = _userAccfbRepository.FindAll(x => x.IdUser==idUser).Select(x=>x.IdAccountFb);
                var contents = _contentRepository.FindAll(x => listAcc.Contains(x.IdFaceBook)&&((type==0)?x.Id>0:x.Type==type) )
                                                 .Include(x=>x.ImagePaths.Where(y=>y.IdUser==idUser));
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
                var user = _userRepository.FindAll(x => x.Id==param.IdUser&&x.HardwareId==param.HwId).FirstOrDefault();
                if (user == null)
                {
                    response.Message="Thông tin user không hợp lệ";
                    return response;
                }
                var fbuser = _userAccfbRepository.FindAll(x=>x.IdUser==param.IdUser).FirstOrDefault();
                if(fbuser==null)
                {
                    response.Message = "Chưa có tài khoản FB nào, hãy đăng nhập 1 tài khoản FB trước";
                    return response;
                }

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
                        IdUser = param.IdUser,
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
                var user = _userRepository.FindAll(x=>x.HardwareId==hwId).FirstOrDefault();
                if (user == null)
                {
                    response.Message="Thông tin user không hợp lệ";
                    return response;
                }
                var data = new ContentDto();
                var content = _contentRepository.GetById(idContent);
                data.Id = content.Id;
                data.Detail = content.Detail;
                if(content.Img==true)
                {
                    var listimg = _imgRepository.FindAll(x => x.IdContent == idContent&&x.IdUser==user.Id);
                    if (listimg!=null && listimg.Any())
                    {
                        data.ListImg = _imgRepository.FindAll(x => x.IdContent == idContent&&x.IdUser==user.Id)
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
                var user = _userRepository.FindAll(x => x.HardwareId==hwId).FirstOrDefault();
                if (user == null)
                {
                    response.Message="Thông tin user không hợp lệ";
                    return response;
                }
                var listid = idContents.Split(',').Select(x=> int.Parse(x)).ToList();
                var data = new List<ContentDto>();
                var contents = _contentRepository.FindAll(x=> listid.Contains(x.Id)).Include(x=>x.ImagePaths);

                data = contents.Select(x=> new ContentDto
                {
                    Id= x.Id,
                    Detail=x.Detail,
                    ListImg = (x.Img==true)?x.ImagePaths.Where(y=>y.IdUser==user.Id).Select(x => new ImgDto
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
