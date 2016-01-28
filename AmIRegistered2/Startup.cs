using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmIRegistered2.Startup))]
namespace AmIRegistered2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
