using System.Web;
using System.Web.Mvc;

namespace Patterns.Repository.Web.Mvc.Client
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
