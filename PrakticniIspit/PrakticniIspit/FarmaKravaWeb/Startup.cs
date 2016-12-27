using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FarmaKravaWeb.Startup))]
namespace FarmaKravaWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
