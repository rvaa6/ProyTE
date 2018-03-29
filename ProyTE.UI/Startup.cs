using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyTE.UI.Startup))]
namespace ProyTE.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
