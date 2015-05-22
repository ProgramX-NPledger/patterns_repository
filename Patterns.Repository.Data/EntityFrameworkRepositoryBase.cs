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
		protected IDbSet<TEntity> Set { get; private set; }

		public EntityFrameworkRepositoryBase(EntityFrameworkUnitOfWork unitOfWork)
			: base(unitOfWork)
		{
			Set=UnitOfWork.Entities.Set<TEntity>();
		}

		public virtual bool Any(Expression<Func<TEntity, bool>> predicate)
		{
			return Set.Any(predicate);
		}

		public void Add(TEntity entity)
		{
			Set.Add(entity);
		}

		public void Delete(TEntity entity)
		{
			Set.Remove(entity);
		}

		public TEntity Single(Expression<Func<TEntity, bool>> predicate)
		{
			return Set.Single(predicate);
		}
	}
}