
using AutoMapper;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.ClassConfigFacebook;
using SmartBot.DataDto.Common;
using SmartBot.DataDto.User;
using System.Data;
using System.Linq;

namespace SmartBot.Services.ClassConfigFacebook
{
    public class ClassConfigFacebookService : IClassConfigFacebookService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;

        public ClassConfigFacebookService( IMapper mapper, ICommonUoW commonUoW)
        {
            //  mình gọi thằng authority trong pipeline ra, gắn nó vào thằng _authorityRepository để dùng

            _mapper = mapper;
            _commonUoW = commonUoW;
        }
        public ResponseBase GetCommentGroup()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code= 0,
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


    }
}
