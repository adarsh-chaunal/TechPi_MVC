using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TechPi.DataAccess.Repository.IRepository
{
	public interface IRepository <T> where T : class
	{
		// T will be Product or any other generic model on which we want to perform CRUD or rather we want to interect with DbContext
		IEnumerable<T> GetAll ();
		//T GetFirstOrDefault();
		T Get(Expression<Func<T, bool>> filter);
		void Add(T entity);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entity);
	}
}
