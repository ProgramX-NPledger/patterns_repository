using System;
using System.Linq;
using System.Linq.Expressions;
namespace Patterns.Repository.Contract
{
	public interface IRepository<TEntity>
	{
		
		void Add(TEntity entity);
		void Delete(TEntity entity);
		TEntity Single(Expression<Func<TEntity, bool>> predicate);
		TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
		IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
		IQueryable<TEntity> Set();


	}
}