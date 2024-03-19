﻿using SmartBot.DataAccess.Interface;
using System.ComponentModel.DataAnnotations;

namespace SmartBot.DataAccess.Base
{
	public class BaseEntity : IBaseEntity
	{
		public BaseEntity()
		{
			Deleted = 0;
		}

		[Key]
		public int Id { get; set; }
		public int Deleted { get; set; }
	}
}
