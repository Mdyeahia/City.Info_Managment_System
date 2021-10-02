using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(City.IMS.Startup))]
namespace City.IMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
