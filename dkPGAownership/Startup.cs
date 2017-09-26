using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dkPGAownership.Startup))]
namespace dkPGAownership
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
