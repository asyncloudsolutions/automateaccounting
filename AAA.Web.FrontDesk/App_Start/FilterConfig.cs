using System.Web;
using System.Web.Mvc;

namespace AAA.Web.FrontDesk
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
