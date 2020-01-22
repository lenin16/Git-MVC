using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdministradorMascotas.Startup))]
namespace AdministradorMascotas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
