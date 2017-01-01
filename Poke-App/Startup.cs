using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Poke_App.Startup))]
namespace Poke_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
