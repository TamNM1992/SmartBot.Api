
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
        public ResponseBase GetProvince()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = new List<Province>()
                {
                    new Province()
                    {
                        Name = "Hà Nội",
                        Districts = new List<string>
                        {
                            "Hai Bà Trưng",
                            "Hoàng Mai",
                            "Thanh Xuân",
                            "Sóc Sơn",
                            "Đông Anh",
                            "Gia Lâm",
                            "Nam Từ Liêm",
                            "Thanh Trì",
                            "Bắc Từ Liêm",
                            "Mê Linh",
                            "Hà Đông",
                        }
                    }
                };
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
        public ResponseBase GetTypeByKey(string key)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = new List<string>()
                {
                    "Nhà bếp",
                    "Sức khỏe",
                    "Sản phẩm",
                    "Nấu ăn",
                    "Dịch vụ",
                    "Mua sắm",
                    "Quán ăn",
                    "Thức ăn nhanh",
                    "Thực phẩm",
                    "Cửa hàng",
                    "Nhà hàng",
                    "Ẩm thực",
                    "đồ ăn",
                };
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
        public ResponseBase GetGroupByTypeAndLocation(string type, string location, string profile)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = new List<GroupDataDto>()
                {
                };
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
        public ResponseBase GetSearchConfig()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = new SearchConfigData()
                {
                    ClassResult ="x1yztbdb",
                    ClassCheckJoin ="x9f619 x1n2onr6 x1ja2u2z x78zum5 xdt5ytf x193iq5w xeuugli x1r8uery x1iyjqo2 xs83m0k x150jy0e x1e558r4 xjkvuk6 x1iorvi4",
                    ClassInfo ="xu06os2 x1ok221b",
                    ClassButtonJoin ="x6s0dn4 x78zum5 x1q0g3np",
                };
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
