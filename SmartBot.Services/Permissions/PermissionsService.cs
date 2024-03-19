
using AutoMapper;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using System.Data;
using System.Linq;

namespace SmartBot.Services.Permissions
{
    public class PermisionService : IPermissionService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;

        public PermisionService( IMapper mapper, ICommonUoW commonUoW)
        {
            //  mình gọi thằng authority trong pipeline ra, gắn nó vào thằng _authorityRepository để dùng

            _mapper = mapper;
            _commonUoW = commonUoW;
        }
        public ResponseBase GetUserPermission(int IdUser)
        {
            ResponseBase response = new ResponseBase();
            try
            {
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
