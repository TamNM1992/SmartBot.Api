
using AutoMapper;
using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Common;
using SmartBot.DataDto.Group;
using SmartBot.DataDto.User;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace SmartBot.Services.Group
{
    public class GroupService : IGroupService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<GroupFb> _groupRepository;
        private readonly ICommonRepository<PageFb> _pageRepository;

        private readonly ICommonRepository<AccountFb> _fbRepository;
        public GroupService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<GroupFb> groupRepository,
             ICommonRepository<AccountFb> fbRepository, ICommonRepository<PageFb> pageRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _groupRepository = groupRepository;
            _fbRepository = fbRepository;
            _pageRepository=pageRepository;
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
                var data = new List<ProvinceDto>()
                {
                    new ProvinceDto()
                    {
                        Id=1,
                        Name = "Hà Nội",
                        Districts = new List<string>
                        {
                            "Hai Bà Trưng",
                            "Hoàng Mai",
                            "Thanh Xuân",
                            //"Sóc Sơn",
                            //"Đông Anh",
                            //"Gia Lâm",
                            //"Nam Từ Liêm",
                            //"Thanh Trì",
                            //"Bắc Từ Liêm",
                            //"Mê Linh",
                            //"Hà Đông",
                        }
                    },
                    new ProvinceDto()
                    {
                        Id = 2,
                        Name = "Tp Hồ Chí Minh",
                        Districts = new List<string>
                        {
                            "Quận 1",
                            "Quận 10",
                            "Thủ Đức",
                            //"Sóc Sơn",
                            //"Đông Anh",
                            //"Gia Lâm",
                            //"Nam Từ Liêm",
                            //"Thanh Trì",
                            //"Bắc Từ Liêm",
                            //"Mê Linh",
                            //"Hà Đông",
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
                var data = new List<string>();
                if (key=="ăn vặt")
                {
                    data.AddRange( new List<string>()
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
                    });
                }
                if (key.Contains("xaydung"))
                {
                    data.AddRange(new List<string>()
                    {
                        "xay",
                        "dung",
                        "thietke",
                        "noithat",
                        "nha",
                        "chungcu",
                        "phong",
                        "khonggiansong",
                    });
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

        public ResponseBase InsertGroup(InsertGroupDto data)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                if(data.Groups.IsNullOrEmpty())
                {
                    response.Message ="input empty";
                    return response;
                }
                var fb = _fbRepository.FindAll(x => x.Id==data.IdFb).SingleOrDefault();
                var newUrl = data.Groups.Select(x => x.Url);
                var oldGroup = _groupRepository.FindAll(x=>x.IdFaceBook==data.IdFb).Select(x => x.Url).AsNoTracking();

                var newGroup = new List<GroupFb>();
                foreach(var item in data.Groups)
                {
                    if(oldGroup.IsNullOrEmpty() || !oldGroup.Contains(item.Url))
                    {
                        var group = new GroupFb()
                        {
                            Name = item.Name.Trim(),
                            Url = item.Url,
                            Type = item.Type.Trim(),
                            NumMember = item.NumMember,
                            NumPostPerDay = item.NumPostPerDay,
                            Description = item.Description,
                            DateUpdate = DateTime.Now,
                            IdFaceBook = data.IdFb,
                        };
                        newGroup.Add(group);
                    }    
                }
                if(newGroup.Any())
                {
                    _commonUoW.BeginTransaction();
                    _groupRepository.InsertMultiple(newGroup);
                    _commonUoW.Commit();
                }
                response.Data = "Success";
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = "False";
                return response;
            }
        }
        public ResponseBase InsertPage(InsertPageDto data)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                if (data.Pages.IsNullOrEmpty())
                {
                    response.Message ="input empty";
                    return response;
                }
                var fb = _fbRepository.FindAll(x => x.Id==data.IdFb).SingleOrDefault();
                var newUrl = data.Pages.Select(x => x.Url);
                var oldGroup = _pageRepository.FindAll(x=>x.IdFaceBook==data.IdFb).Select(x => x.Url).AsNoTracking();
                var newGroup = new List<PageFb>();
                foreach (var item in data.Pages)
                {
                    if (oldGroup.IsNullOrEmpty() || !oldGroup.Contains(item.Url))
                    {
                        var group = new PageFb()
                        {
                            Name = item.Name.Trim(),
                            Url = item.Url,
                            Type = item.Type.Trim(),
                            Distance = item.Distance,
                            Rate = item.Rate,
                            Status = item.Status,
                            Price = item.Price,
                            NumFollowers = item.NumFollowers,
                            NumPostPerDay = item.PostPerDay,
                            Description = item.Description,
                            DateUpdate = DateTime.Now,
                            IdFaceBook = data.IdFb,
                        };
                        newGroup.Add(group);
                    }
                }
                if (newGroup.Any())
                {
                    _commonUoW.BeginTransaction();
                    _pageRepository.InsertMultiple(newGroup);
                    _commonUoW.Commit();
                }
                response.Data = "Success";
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = "False";
                return response;
            }
        }
        public ResponseBase InsertGroupFB(InsertGroupFBDto data)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var data = new Dictionary<string, string>();
                var group = _groupRepository.FindAll(x=>x.IdFaceBook==idFacebook);
                var deadlineUpdate = group.FirstOrDefault().DateUpdate-DateTime.Now;
                if (!group.Any() || deadlineUpdate.Value.Days>30)
                {
                    response.Code = 1001;
                    response.Message = "update data";
                    return response ;
                }
                data = group.Select(x => new
                {
                    x.Name,
                    x.Url,
                }).ToDictionary(x=> x.Name,x=>x.Url);

                response.Data = data;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = "False";
                return response;
            }
        }
        public ResponseBase UpdateGroup(UpdateGroupDto data)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var idFb = _fbRepository.FindAll(x=>x.FbUser==data.FbUser).SingleOrDefault().Id;

                var group = _groupRepository.FindAll();
                if (group != null)
                {
                    var temp = group.Select(x => new
                    {
                        x.Id,
                        x.Url,
                    }).ToDictionary(x=>x.Id, x=>x.Url);
                    //foreach (var item in data.Groups)
                    //{
                    //    if(temp.Values.Contains(item.Value))
                    //    {
                    //        if(fbGroup.Contains(te))
                    //    }    
                    //}    
                }


                response.Data = data;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = "False";
                return response;
            }
        }
    }
}
