using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WelcomeAWS.Startup))]
namespace WelcomeAWS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
