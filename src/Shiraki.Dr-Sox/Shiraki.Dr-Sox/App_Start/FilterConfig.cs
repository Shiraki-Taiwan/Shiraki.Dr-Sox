using System.Web;
using System.Web.Mvc;

namespace Shiraki.Dr_Sox
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
