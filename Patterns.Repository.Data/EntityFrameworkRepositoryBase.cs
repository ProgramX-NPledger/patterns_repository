using Patterns.Repository.Contract;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Data.Entity;
using System;

namespace Patterns.Repository.Data
{
	public class EntityFrameworkRepositoryBase 
	{
		protected EntityFrameworkUnitOfWork UnitOfWork { get; private set; }

		public EntityFrameworkRepositoryBase(EntityFrameworkUnitOfWork unitOfWork)
		{
			UnitOfWork=unitOfWork;
		}



	}

	public class EntityFrameworkRepositoryBase<TEntity> : EntityFrameworkRepositoryBase, IRepository<TEntity>
		where TEntity : class
	{
		protected IDbSet<TEntity> DbSet { get; private set; }

		public EntityFrameworkRepositoryBase(EntityFrameworkUnitOfWork unitOfWork)
			: base(unitOfWork)
		{
			DbSet=UnitOfWork.Entities.Set<TEntity>();
		}

		public virtual bool Any(Expression<Func<TEntity, bool>> predicate)
		{
			return DbSet.Any(predicate);
		}

		public void Add(TEntity entity)
		{
			DbSet.Add(entity);
		}

		public void Delete(TEntity entity)
		{
			DbSet.Remove(entity);
		}

		public TEntity Single(Expression<Func<TEntity, bool>> predicate)
		{
			return DbSet.Single(predicate);
		}

		public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
		{
			return DbSet.SingleOrDefault(predicate);
		}

		public IQueryable<TEntity> Where(Expression<Func<TEntity,bool>> predicate)
		{
			return DbSet.Where(predicate);
		}

		public IQueryable<TEntity> Set()
		{
			return DbSet;
		}
	}
}