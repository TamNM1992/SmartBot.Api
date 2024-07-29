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
                            label = "Tháng 1",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 2",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 3",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 4",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 5",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 6",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 7",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 8",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 9",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 10",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 11",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
                            }
                        },
                        new FakeDataDto()
                        {
                            label = "Tháng 12",
                            data= new DTset
                            {
                                dataset1=_random.Next(50,200),
                                dataset2=_random.Next(50,200),
                                dataset3=65,
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
