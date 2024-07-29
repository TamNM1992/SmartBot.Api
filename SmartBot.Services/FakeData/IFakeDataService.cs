using SmartBot.DataDto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.Services.FakeData
{
    public interface IFakeDataService
    {
        public ResponseBase GetFakeData();
    }
}
