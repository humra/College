using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zadatak01.Startup))]
namespace Zadatak01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
