using log4net;
using Patterns.Repository.Contract;
using System;
namespace Patterns.Repository.Data
{
	public class EntityFrameworkUnitOfWorkFactory : IUnitOfWorkFactory
	{
		protected string ConnectionString { get; set; }
		public ILog Log { get; set; }

		public EntityFrameworkUnitOfWorkFactory(string connectionString)
		{
			ConnectionString = connectionString;
			Log = LogManager.GetLogger(this.GetType());
		}

		public IUnitOfWork Create()
		{
			return CreateInternal();
		}

		public IUnitOfWork CreateInternal()
		{
			string entityFrameworkConnectionString = string.Format("metadata=res://*/SopModel.csdl|res://*/SopModel.ssdl|res://*/SopModel.msl;provider=System.Data.SqlClient;provider connection string=\"{0}\"", ConnectionString);
			EntityFrameworkUnitOfWork unitOfWork;
			try
			{
				SopEntities sopEntities = new SopEntities(entityFrameworkConnectionString);
				unitOfWork = new EntityFrameworkUnitOfWork(sopEntities);
			}
			catch (Exception ex)
			{
				throw;

			}
			return unitOfWork;
		}
	}
}