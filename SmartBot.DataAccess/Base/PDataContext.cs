using Microsoft.EntityFrameworkCore;
using SmartBot.DataAccess.Interface;

namespace SmartBot.DataAccess.Base
{
	public abstract class PDataContext : DbContext, IDBContext
	{
		protected PDataContext(DbContextOptions options) : base(options)
		{

		}
	}
}
