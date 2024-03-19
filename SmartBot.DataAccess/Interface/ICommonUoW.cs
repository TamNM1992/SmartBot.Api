
using SmartBot.DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataAccess.Interface
{
	public interface ICommonUoW : IUnitOfWork<CommonDBContext>
	{

	}
}
