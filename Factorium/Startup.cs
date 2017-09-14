using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Factorium.Startup))]
namespace Factorium
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
