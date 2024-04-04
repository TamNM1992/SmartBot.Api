
using AutoMapper;
using Azure;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Comment;
using SmartBot.DataDto.Common;
using SmartBot.DataDto.User;
using System.Data;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SmartBot.Services.Comment
{
    public class CommentService : ICommentService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;

        public CommentService( IMapper mapper, ICommonUoW commonUoW)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
        }
        public ResponseBase GetDataCommentGroup()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code= 0,
                    Message = "Success",
                    Data = new List<CommentGroupData>()
                    {
                        new CommentGroupData() 
                        {
                        STT=1,
                        ResponseID="Comment kèm ảnh vào group",
                        ContentID="Local01",
                        Type="Comment",
                        Status="0",
                        UserID="",
                        Link="https://www.facebook.com/groups/4577494692330519/posts/7336025263144101/",
                        Content="Comment dạo test thử phát thôi",
                        Image="D:/SmartBotBeta/Database/1045.jpg",
                        Create_time="3/24/2024 9:14:46 AM"
                        },
                        new CommentGroupData()
                        {
                        STT=2,
                        ResponseID="Comment vào group",
                        ContentID="Local02",
                        Type="Comment",
                        Status="0",
                        UserID="",
                        Link="https://www.facebook.com/groups/4577494692330519/posts/7336025263144101/",
                        Content="Comment dạo test thử phát thôi",
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
