using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationAspNetAzure.Startup))]
namespace ApplicationAspNetAzure
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
