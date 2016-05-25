using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vjezbe05.Startup))]
namespace Vjezbe05
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
