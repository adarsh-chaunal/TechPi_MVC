using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechPi.DataAccess.Data;
using TechPi.DataAccess.Repository.IRepository;
using TechPi.Models;

namespace TechPi.DataAccess.Repository
{
	public class PartRepository : Repository<Part>, IPartRepository
	{
		private ApplicationDbContext _db;
        public PartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

		public void Update(Part obj)
		{
			_db.Parts.Update(obj);
		}
	}
}
