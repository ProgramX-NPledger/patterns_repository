using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repository.Contract
{
	public interface IUnitOfWorkFactory
	{
		IUnitOfWork Create();

	}
}
