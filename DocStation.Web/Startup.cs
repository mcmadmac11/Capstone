using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DocStation.Web.Startup))]

namespace DocStation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}