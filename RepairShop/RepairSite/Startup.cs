using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepairSite.Startup))]
namespace RepairSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
