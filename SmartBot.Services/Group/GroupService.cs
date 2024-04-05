
using AutoMapper;
using Azure;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Common;
using SmartBot.DataDto.Group;
using SmartBot.DataDto.User;
using System.Data;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SmartBot.Services.Group
{
    public class GroupService : IGroupService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;

        public GroupService( IMapper mapper, ICommonUoW commonUoW)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
        }
        public ResponseBase GetDataGroupPost()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code= 0,
                    Message = "Success",
                    Data = new List<GroupPostData>()
                    {
                        new GroupPostData() 
                        {
                        STT=1,
                        ResponseID="Group kèm ảnh",
                        ContentID="Local01",
                        Type="Group",
                        Status="0",
                        UserID="",
                        Link="https://www.facebook.com/groups/2364874053821532",
                        Content="test thử phát có ảnh",
                        Image="D:/SmartBotBeta/Database/1045.jpg",
                        Create_time="3/24/2024 9:14:46 AM"
                        },
                        new GroupPostData()
                        {
                        STT=2,
                        ResponseID="Group không ảnh",
                        ContentID="Local02",
                        Type="Group",
                        Status="0",
                        UserID="",
                        Link="https://www.facebook.com/groups/2364874053821532",
                        Content="test thử phát không ảnh",
                        Image="",
                        Create_time="3/24/2024 9:14:46 AM"
                        },
                    },

                };
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
