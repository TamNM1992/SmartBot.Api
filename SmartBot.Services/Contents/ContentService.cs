
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



        public ContentService( IMapper mapper, ICommonUoW commonUoW, ICommonRepository<ContentFb> contentRepository,
            ICommonRepository<AccountFb> accFbRepository, ICommonRepository<UsersAccountFb> userAccfbRepository,
            ICommonRepository<ClientCustomer> clientRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _contentRepository = contentRepository;
            _accFbRepository = accFbRepository;
            _userAccfbRepository= userAccfbRepository;
            _clientRepository = clientRepository;
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


    }
}
