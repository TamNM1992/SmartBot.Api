
using SmartBot.DataAccess.DBContext;
using SmartBot.DataAccess.Interface;

namespace SmartBot.DataAccess.UnitOfWork
{
	public class CommonUoW : UnitOfWork<CommonDBContext>, ICommonUoW
	{


		public CommonUoW(CommonDBContext context) : base(context)
		{
		}

	}
}
