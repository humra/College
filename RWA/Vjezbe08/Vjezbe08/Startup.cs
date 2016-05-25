using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vjezbe08.Startup))]
namespace Vjezbe08
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
