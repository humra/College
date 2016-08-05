using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IspitPriprema.Startup))]
namespace IspitPriprema
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
