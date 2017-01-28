using System.Web;
using System.Web.Mvc;

namespace Sebastian.Calentamiento
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
