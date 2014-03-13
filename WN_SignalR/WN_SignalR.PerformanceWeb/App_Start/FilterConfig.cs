using System.Web;
using System.Web.Mvc;

namespace WN_SignalR.PerformanceWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
