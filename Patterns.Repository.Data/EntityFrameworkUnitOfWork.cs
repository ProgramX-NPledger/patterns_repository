using log4net;
using Patterns.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repository.Data
{
    public class EntityFrameworkUnitOfWork : IUnitOfWork
    {
		public ILog Log { get; set; }
		public SopEntities Entities { get; set; }

		public EntityFrameworkUnitOfWork(SopEntities sopEntities)
		{
			Entities = sopEntities;
		}

		public IInvoiceRepository CreateInvoiceRepository()
		{
			return new InvoiceRepository(this);
		}

		public IRepository<TEntity> CreateRepositoryFor<TEntity>()
			where TEntity : class
		{
			return new EntityFrameworkRepositoryBase<TEntity>(this);
		}

		public void SaveChanges()
		{
			try
			{
				Entities.SaveChanges();
			}
			catch (DbEntityValidationException dbEntityValidationEx)
			{
				StringBuilder sb = new StringBuilder();

			}
		}

		public void Dispose()
		{
			Entities.Dispose();
		}
	}
}
