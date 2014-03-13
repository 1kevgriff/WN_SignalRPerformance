using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WN_SignalR.PerformanceWeb.Startup))]
namespace WN_SignalR.PerformanceWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
