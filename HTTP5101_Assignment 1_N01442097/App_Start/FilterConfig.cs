using System.Web;
using System.Web.Mvc;

namespace HTTP5101_Assignment_1_N01442097
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
