using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zadatak03.Startup))]
namespace Zadatak03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
