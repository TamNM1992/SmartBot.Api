
using SmartBot.DataAccess.DBContext;
using SmartBot.DataAccess.Interface;

namespace SmartBot.DataAccess.Repositories
{
	public class CommonRepository<T> : Repository<CommonDBContext, T>, ICommonRepository<T> where T : class
	{
		public CommonRepository(CommonDBContext context) : base(context)
		{

		}
	}
}
