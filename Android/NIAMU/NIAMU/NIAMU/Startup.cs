using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NIAMU.Startup))]
namespace NIAMU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
