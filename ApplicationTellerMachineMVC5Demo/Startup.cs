using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationTellerMachineMVC5Demo.Startup))]
namespace ApplicationTellerMachineMVC5Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
