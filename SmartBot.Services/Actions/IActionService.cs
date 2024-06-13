using SmartBot.DataDto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.Services.Action
{
    public interface IActionService
    {
        public ResponseBase GetActionHistory(int IdUser);
    }
}
