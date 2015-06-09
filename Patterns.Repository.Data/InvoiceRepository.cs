using Patterns.Repository.Contract;
using Patterns.Repository.Model;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Data.Entity;

namespace Patterns.Repository.Data
{
	public class InvoiceRepository : EntityFrameworkRepositoryBase<Invoice>, IInvoiceRepository
	{
		public InvoiceRepository(EntityFrameworkUnitOfWork unitOfWork)
			: base(unitOfWork)
		{

		}



		public IEnumerable<Invoice> GetOutstandingInvoicesForCustomer(int customerId)
		{
			return DbSet.Include("InvoiceLines.StockItem").Include("Customer")
				.Where(q => q.Customer.Id == customerId);
		}
	}
}