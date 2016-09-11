using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SitioAbogaciaMVC.Startup))]
namespace SitioAbogaciaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          //  ConfigureAuth(app);
        }
    }
}
