
using AutoMapper;
using Azure;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Common;
using SmartBot.DataDto.NewFeed;
using SmartBot.DataDto.User;
using System.Data;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SmartBot.Services.NewFeed
{
    public class NewFeedService : INewFeedService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;

        public NewFeedService( IMapper mapper, ICommonUoW commonUoW)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
        }
        public ResponseBase GetDataNewFeed()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code= 0,
                    Message = "Success",
                    Data = new List<NewFeedData>()
                    {
                        new NewFeedData() 
                        {
                        STT=1,
                        ResponseID="NewFeed kèm ảnh",
                        ContentID="Local01",
                        Type="NewFeed",
                        Status="0",
                        UserID="",
                        Link="https://www.facebook.com",
                        Content="test thử phát có ảnh",
                        Image="D:/SmartBotBeta/Database/1045.jpg",
                        Create_time="3/24/2024 9:14:46 AM"
                        },
                        new NewFeedData()
                        {
                        STT=2,
                        ResponseID="NewFeed không ảnh",
                        ContentID="Local02",
                        Type="NewFeed",
                        Status="0",
                        UserID="",
                        Link="https://www.facebook.com",
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
