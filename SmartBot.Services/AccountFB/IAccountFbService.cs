using SmartBot.DataDto.AccountFb;
using SmartBot.DataDto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.Services.AccountFB
{
    public interface IAccountFbService
    {
        public ResponseBase InsertAccountFb(InsertAccountFbDto param);
        public ResponseBase GetFaceBookId(string fbUserName);
        public ResponseBase TestChart();
    }
}
