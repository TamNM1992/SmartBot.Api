using AutoMapper;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.FakeData;
using SmartBot.DataDto.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.Services.FakeData
{
    public class FakeDataService : IFakeDataService
    {
        private Random _random;
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        public FakeDataService(Random random, IMapper mapper, ICommonUoW commonUoW)
        { 
            _random = random;
            _mapper = mapper;
            _commonUoW = commonUoW;
        }
        public ResponseBase GetFakeData()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code= 0,
                    Message = "Success",
                    Data = new List<FakeDataDto>()
                    {
                        new FakeDataDto()
                        {
                            Label = "Tháng 1",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 2",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 3",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 4",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 5",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 6",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 7",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 8",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 9",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 10",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 11",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            Label = "Tháng 12",
                            Data= new DTset
                            {
                                Dataset1=_random.Next(50,200),
                                Dataset2=_random.Next(50,200),
                                Dataset3=65,
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
    }
}
