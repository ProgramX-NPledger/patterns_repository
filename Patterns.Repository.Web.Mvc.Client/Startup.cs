using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Patterns.Repository.Web.Mvc.Client.Startup))]
namespace Patterns.Repository.Web.Mvc.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
