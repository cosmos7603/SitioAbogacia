using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SitioAbogaciaMVC2.Startup))]
namespace SitioAbogaciaMVC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
