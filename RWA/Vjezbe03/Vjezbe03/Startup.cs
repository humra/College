using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vjezbe03.Startup))]
namespace Vjezbe03
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
