using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthAW.Startup))]
namespace HealthAW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
