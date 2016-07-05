using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ishod06.Startup))]
namespace Ishod06
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
