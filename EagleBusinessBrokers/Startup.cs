using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EagleBusinessBrokers.Startup))]
namespace EagleBusinessBrokers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
