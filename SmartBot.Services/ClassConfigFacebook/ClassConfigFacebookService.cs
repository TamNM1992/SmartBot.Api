using AutoMapper;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.ClassConfigFacebook;
using SmartBot.DataDto.Common;

namespace SmartBot.Services.ClassConfigFacebook
{
    public class ClassConfigFacebookService : IClassConfigFacebookService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<ClassData> _classDataRepository;

        public ClassConfigFacebookService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<ClassData> classDataRepository)
        {
            //  mình gọi thằng authority trong pipeline ra, gắn nó vào thằng _authorityRepository để dùng

            _mapper = mapper;
            _commonUoW = commonUoW;
            _classDataRepository = classDataRepository;
        }
        public ResponseBase GetCommentGroup()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code = 0,
                    Message = "Success",
                    Data = new CommentGroupDataDto()
                    {
                        DelayTimeLoad = 5000,
                        DelayAction = 1000,
                        CommentBox = new ClassFB()
                        {
                            ClassName = "xzsf02u x1a2a7pz x1n2onr6 x14wi4xw notranslate",
                            Index = 0,
                        },
                        //ButtonImg = new ClassFB()
                        //{
                        //    ClassName = "x1rg5ohu x1mnrxsn x1w0mnb",
                        //    Index = 7,
                        //},
                        ButtonSubmit = new ClassFB()
                        {
                            ClassName = "x9f619 x1n2onr6 x1ja2u2z x78zum5 x2lah0s x1qughib x6s0dn4 xozqiw3 x1q0g3np xcud41i x139jcc6 x4cne27 xifccgj",
                            Index = 0,
                        },
                        SelectPostBar = new Dictionary<string, ClassFB>()
                        {
                            {
                                "Like",
                                new ClassFB()
                                {
                                    ClassName = "x9f619 x1n2onr6 x1ja2u2z x78zum5 xdt5ytf x193iq5w xeuugli x1r8uery x1iyjqo2 xs83m0k xg83lxy x1h0ha7o x10b6aqq x1yrsyyn",
                                    Index = 0,
                                }
                            },
                            {
                                "Comment",
                                new ClassFB()
                                {
                                    ClassName = "x9f619 x1n2onr6 x1ja2u2z x78zum5 xdt5ytf x193iq5w xeuugli x1r8uery x1iyjqo2 xs83m0k xg83lxy x1h0ha7o x10b6aqq x1yrsyyn",
                                    Index = 1,
                                }
                            },
                            {
                                "Share",
                                new ClassFB()
                                {
                                    ClassName = "x9f619 x1n2onr6 x1ja2u2z x78zum5 xdt5ytf x193iq5w xeuugli x1r8uery x1iyjqo2 xs83m0k xg83lxy x1h0ha7o x10b6aqq x1yrsyyn",
                                    Index = 2,
                                }
                            },
                        },
                        SelectCommentBar = new Dictionary<string, ClassFB>()
                        {
                            {
                                "Sticker Avatar",
                                new ClassFB()
                                {
                                    ClassName = "x1rg5ohu x1mnrxsn x1w0mnb",
                                    Index = 5,
                                }
                            },
                            {
                                "Emoji",
                                new ClassFB()
                                {
                                    ClassName = "x1rg5ohu x1mnrxsn x1w0mnb",
                                    Index = 6,
                                }
                            },
                            {
                                "Image",
                                new ClassFB()
                                {
                                    ClassName = "x1rg5ohu x1mnrxsn x1w0mnb",
                                    Index = 7,
                                }
                            },
                            {
                                "Gif",
                                new ClassFB()
                                {
                                    ClassName = "x1rg5ohu x1mnrxsn x1w0mnb",
                                    Index = 8,
                                }
                            },
                            {
                                "Sticker",
                                new ClassFB()
                                {
                                    ClassName = "x1rg5ohu x1mnrxsn x1w0mnb",
                                    Index = 9,
                                }
                            }
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
        public ResponseBase GetShareGroup()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code = 0,
                    Message = "Success",
                    Data = new ShareGroupDataDto()
                    {
                        DelayTimeLoad = 5000,
                        DelayAction = 1000,
                        ButtonShare = new ClassFB()
                        {
                            ClassName = "x9f619 x1n2onr6 x1ja2u2z x78zum5 xdt5ytf x193iq5w xeuugli x1r8uery x1iyjqo2 xs83m0k xg83lxy x1h0ha7o x10b6aqq x1yrsyyn",
                            Index = 3,

                        },
                        ButtonSubmit = new ClassFB()
                        {
                            ClassName = "x9f619 x1n2onr6 x1ja2u2z x78zum5 x2lah0s x1qughib x6s0dn4 xozqiw3 x1q0g3np xcud41i x139jcc6 x4cne27 xifccgj",
                            Index = 0,
                        },
                        SelectShareBar1 = new Dictionary<string, ClassFB>()
                        {
                            {
                                "Share to Feed",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 0,
                                }
                            },
                            {
                                "Share to Mess",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 1,
                                }
                            },
                            {
                                "Share to WhatsApp",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 2,
                                }
                            },
                            {
                                "Share to Page",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 3,
                                }
                            },
                            {
                                "Share to Group",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 4,
                                }
                            },
                            {
                                "Share to Friend Feed",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 5,
                                }
                            },
                            {
                                "Share to Twitter",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 6,
                                }
                            },
                            {
                                "Copy Url",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 7,
                                }
                            }
                        },
                        SelectShareBar2 = new Dictionary<string, ClassFB>()
                        {
                            {
                                "Share to Feed",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 0,
                                }
                            },
                            {
                                "Share to Mess",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 1,
                                }
                            },
                            {
                                "Share to WhatsApp",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 2,
                                }
                            },
                            {
                                "Share to Page",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 3,
                                }
                            },
                            {
                                "Share to Group",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 4,
                                }
                            },
                            {
                                "Share to Friend Feed",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 5,
                                }
                            },
                            {
                                "Share to Twitter",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 6,
                                }
                            },
                            {
                                "Copy Url",
                                new ClassFB()
                                {
                                    ClassName = "x6s0dn4 x1q0q8m5 x1qhh985 xu3j5b3 xcfux6l x26u7qi xm0m39n x13fuv20 x972fbf x9f619 x78zum5 x1q0g3np x1iyjqo2 xs83m0k x1qughib xat24cr x11i5rnm x1mh8g0r xdj266r x2lwn1j xeuugli x18d9i69 x1sxyh0 xurb0ha xexx8yu x1n2onr6 x1ja2u2z",
                                    Index = 7,
                                }
                            }
                        }
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
        public ResponseBase GetCommentConfig()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code = 0,
                    Message = "Success",
                    Data = new CommentConfig()
                    {
                        DelayPreLoad = 2000,
                        DelayWaitingForAction = 1000,
                        DelayWaitingForWriteText = 300,
                        Content = "",
                        ButtonComment = new ClassFB()
                        {
                            ClassName = "x9f619 x1n2onr6 x1ja2u2z x78zum5 xdt5ytf x193iq5w xeuugli x1r8uery x1iyjqo2 xs83m0k xg83lxy x1h0ha7o x10b6aqq x1yrsyyn",
                            Index = 1,
                        },
                        ButtonSubmit = new ClassFB()
                        {
                            ClassName = "x9f619 x1n2onr6 x1ja2u2z x78zum5 x2lah0s x1qughib x6s0dn4 xozqiw3 x1q0g3np xcud41i x139jcc6 x4cne27 xifccgj",
                            Index = 0,
                        }
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
        public ResponseBase GetUpImgConfig()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code = 0,
                    Message = "Success",
                    Data = new UpImgConfig()
                    {
                        DelayPreLoad = 2000,
                        DelayWaitingForAction = 1000,
                        DelayWaitingForSendImg = 5000,
                        PathImg = "",
                        ButtonImg = new ClassFB()
                        {
                            ClassName = "x1rg5ohu x1mnrxsn x1w0mnb",
                            Index = 7,
                        },
                        ButtonSubmit = new ClassFB()
                        {
                            ClassName = "x9f619 x1n2onr6 x1ja2u2z x78zum5 x2lah0s x1qughib x6s0dn4 xozqiw3 x1q0g3np xcud41i x139jcc6 x4cne27 xifccgj",
                            Index = 0,
                        }
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
        public ResponseBase GetFbClassName(int type)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var classConfig = _classDataRepository.FindAll(x => x.Type == type).ToList();
                return new ResponseBase()
                {
                    Code = 0,
                    Message = "Success",
                    Data = new PostWallDto()
                    {
                        DelayTimeLoad = 5000,
                        DelayAction = 1000,
                        ClassNames = classConfig.Select(x => new ClassFB
                        {
                            ClassName = x.ClassName,
                            Index = x.ClassIndex
                        }).ToList(),
                    }

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
