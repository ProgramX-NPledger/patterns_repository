using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Repository.Contract;
using Patterns.Repository.Data;
using Patterns.Repository.Model;

namespace Patterns.Repository.Tests
{
	[TestClass]
	public class RepositoryTest
	{
		protected readonly string ConnectionString = "data source=(localdb)\\ProjectsV12;initial catalog=Patterns_Repository_DB;integrated security=True;MultipleActiveResultSets=True;App=Patterns_Repository";

		/// <summary>
		/// Uses a strongly typed repository to retrieve data based on a specific criteria/request requirement.
		/// The IInvoiceRepository implementation should know how to load its dependencies.
		/// </summary>
		[TestMethod]
		public void GetInvoicesForCustomerTest()
		{
			IUnitOfWorkFactory unitOfWorkFactory = new EntityFrameworkUnitOfWorkFactory(ConnectionString);
			using (IUnitOfWork unitOfWork = unitOfWorkFactory.Create())
			{
				IInvoiceRepository invoiceRepository = unitOfWork.CreateInvoiceRepository();
				IEnumerable<Invoice> actual= invoiceRepository.GetOutstandingInvoicesForCustomer(1);
				Assert.IsNotNull(actual);
				Assert.AreEqual(2,actual.Count());
			}
		}

		/// <summary>
		/// Uses a weakly-typed repository to retrieve the entire Set.
		/// This is useful for accessing discrete data such as lookups, etc.
		/// </summary>
		[TestMethod]
		public void GetCustomersTest()
		{
			IUnitOfWorkFactory unitOfWorkFactory=new EntityFrameworkUnitOfWorkFactory(ConnectionString);
			using (IUnitOfWork unitOfWork = unitOfWorkFactory.Create())
			{
				IRepository<Customer> customerRepository = unitOfWork.CreateRepositoryFor<Customer>();
				IEnumerable<Customer> actual = customerRepository.Set();
				Assert.IsNotNull(actual);
				Assert.IsTrue(actual.Any());
			}
		}

		/// <summary>
		/// Uses a weakly-typed repository to add a new Customer
		/// </summary>
		[TestMethod]
		public void AddACustomerTest()
		{
			IUnitOfWorkFactory unitOfWorkFactory=new EntityFrameworkUnitOfWorkFactory(ConnectionString);
			using (IUnitOfWork unitOfWork = unitOfWorkFactory.Create())
			{
				IRepository<Customer> customerRepository = unitOfWork.CreateRepositoryFor<Customer>();
				string newCustomerName = Guid.NewGuid().ToString("N");
				Customer customer = new Customer()
				{
					Name = newCustomerName
				};
				customerRepository.Add(customer);
				unitOfWork.SaveChanges();

				Assert.IsFalse(customer.Id==0);
				Customer savedCustomer = customerRepository.Single(q => q.Id == customer.Id);
				Assert.IsNotNull(savedCustomer);
				Assert.AreEqual(newCustomerName,savedCustomer.Name);
			}
		}

		
		/// <summary>
		/// Use a TransactionScope to wrap the repository operations within a transaction.
		/// Exercise caution when using the default constructor of TransactionScope:
		///    http://blogs.msdn.com/b/dbrowne/archive/2010/05/21/using-new-transactionscope-considered-harmful.aspx
		/// </summary>
		[TestMethod]
		public void AddACustomerWithinAFailingTransaction_ShouldNotCommitTheCustomerTest()
		{			
			IUnitOfWorkFactory unitOfWorkFactory = new EntityFrameworkUnitOfWorkFactory(ConnectionString);
			using (IUnitOfWork unitOfWork = unitOfWorkFactory.Create())
			{
				IRepository<Customer> customerRepository = unitOfWork.CreateRepositoryFor<Customer>();
				string newCustomerName = Guid.NewGuid().ToString("N");
				Customer customer = new Customer()
				{
					Name = newCustomerName
				};
				customerRepository.Add(customer);

				try
				{
					using (TransactionScope transactionScope = new TransactionScope())
					{
						unitOfWork.SaveChanges();
						throw new ApplicationException();
					}
				}
				catch (ApplicationException)
				{
				}

				Customer savedCustomer = customerRepository.SingleOrDefault(q => q.Name == customer.Name);
				Assert.IsNull(savedCustomer);
			}
		}

		/// <summary>
		/// Use a TransactionScope to wrap the repository operations within a transaction.
		/// Exercise caution when using the default constructor of TransactionScope:
		///    http://blogs.msdn.com/b/dbrowne/archive/2010/05/21/using-new-transactionscope-considered-harmful.aspx
		/// </summary>
		[TestMethod]
		public void AddACustomerWithinASucceedingTransaction_ShouldCommitTheCustomerTest()
		{		
			IUnitOfWorkFactory unitOfWorkFactory = new EntityFrameworkUnitOfWorkFactory(ConnectionString);
			using (IUnitOfWork unitOfWork = unitOfWorkFactory.Create())
			{
				IRepository<Customer> customerRepository = unitOfWork.CreateRepositoryFor<Customer>();
				string newCustomerName = Guid.NewGuid().ToString("N");
				Customer customer = new Customer()
				{
					Name = newCustomerName
				};
				customerRepository.Add(customer);

				using (TransactionScope transactionScope = new TransactionScope())
				{
					unitOfWork.SaveChanges();

					Assert.IsTrue(customer.Id != 0);
					Customer savedCustomerWithinTransaction = customerRepository.SingleOrDefault(q => q.Name==newCustomerName);
					Assert.IsNotNull(savedCustomerWithinTransaction);


					transactionScope.Complete();					
				}

				Assert.IsFalse(customer.Id == 0);
				Customer savedCustomer = customerRepository.Single(q => q.Id==customer.Id);
				Assert.IsNotNull(savedCustomer);
			}
		}

		/// <summary>
		/// A Unit of Work Pipeline allows multiple tasks to be concatenated, extending opportunities for code re-use
		/// The Set underlying the Unit of Work Pipeline means if the Pipeline is wrapped in a Transaction, the entire Pipeline will fail
		/// </summary>
		[TestMethod]
		public void RaiseAnInvoiceUsingUnitOfWorkPipelineTest()
		{
			//http://stackoverflow.com/questions/14160788/how-to-use-transactionscope-properly
			
		}
		
	}
}
