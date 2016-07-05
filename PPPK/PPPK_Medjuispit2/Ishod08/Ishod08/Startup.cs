using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ishod08.Startup))]
namespace Ishod08
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
