using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Santa_Tecla.Startup))]
namespace Santa_Tecla
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
