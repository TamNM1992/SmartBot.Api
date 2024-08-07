﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataAccess.Interface
{
	public interface IUnitOfWork<D> : IDisposable where D : IDBContext
	{
		void BeginTransaction();
		/// <summary>
		/// Call save change from db context
		/// </summary>
		int Commit(bool isTrackChanged = true);
		Task<int> CommitAsync(bool isTrackChanged = true);

		void RollBack();
	}
}
