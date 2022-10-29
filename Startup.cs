using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PosShopManagement.Startup))]
namespace PosShopManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
