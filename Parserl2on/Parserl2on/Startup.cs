using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Parserl2on.Startup))]
namespace Parserl2on
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
