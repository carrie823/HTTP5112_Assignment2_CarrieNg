using System.Web;
using System.Web.Mvc;

namespace HTTP5112_Assign2_CarrieNg
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
