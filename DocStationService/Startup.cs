using Microsoft.Azure.Mobile.Server.Config;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(DocStationService.Startup))]

namespace DocStationService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            new MobileAppConfiguration()
                .AddMobileAppHomeController()
                .MapApiControllers()
                .AddTables(
                    new Microsoft.Azure.Mobile.Server.Tables.Config.MobileAppTableConfiguration()
                    .MapTableControllers()
                    .AddEntityFramework()
                    )
                    .AddPushNotifications()
                    .ApplyTo(config);


            
        }
    }
}