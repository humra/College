using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vjezbe04.Startup))]
namespace Vjezbe04
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
