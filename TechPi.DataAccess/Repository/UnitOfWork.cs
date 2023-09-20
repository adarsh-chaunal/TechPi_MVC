using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPi.DataAccess.Data;
using TechPi.DataAccess.Repository.IRepository;

namespace TechPi.DataAccess.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private ApplicationDbContext _db;
		public IProductRepository Product { get; private set; }
		public IPartRepository Part { get; private set; }
		public UnitOfWork(ApplicationDbContext db)
		{
			_db = db;
			Product = new ProductRepository(_db);
			Part = new PartRepository(_db);
		}

		public void Save()
		{
			_db.SaveChanges();
		}
	}
}
