using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zadatak02.Startup))]
namespace Zadatak02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
