using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vjezbe02.Startup))]
namespace Vjezbe02
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
