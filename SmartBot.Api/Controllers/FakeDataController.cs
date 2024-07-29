using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartBot.Services.Users;
using SmartBot.Services;
using SmartBot.Services.FakeData;
using SmartBot.DataDto.Base;

namespace SmartBot.Api.Controllers
{
    public class FakeDataController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFakeDataService _fakeDataService;

        public FakeDataController(IMapper mapper, IFakeDataService fakeDataService)
        {
            _mapper = mapper;
            _fakeDataService = fakeDataService;
        }

        [HttpGet("get-fakedata")]
        public ResponseBase GetFakeData()
        {
            var item = _fakeDataService.GetFakeData();
            return item;
        }
    }
}
