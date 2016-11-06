using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DesafioTenisWEB.Startup))]
namespace DesafioTenisWEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
