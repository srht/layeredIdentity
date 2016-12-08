using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kitapsec.Web.Startup))]
namespace Kitapsec.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
