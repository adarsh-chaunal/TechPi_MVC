﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPi.DataAccess.Repository.IRepository
{
	public interface IUnitOfWork
	{
		IProductRepository Product { get; }
		IPartRepository Part { get; }

		void Save();
	}
}
