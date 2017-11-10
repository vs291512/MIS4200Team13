using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentricTeam13.Startup))]
namespace CentricTeam13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
