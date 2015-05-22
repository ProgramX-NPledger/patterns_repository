using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repository.Data
{
	public partial class SopEntities 
	{
		public SopEntities(string connectionString)
			: base(connectionString)
		{

		}
	}
}
