using System.Web;
using System.Web.Mvc;
using trabalhoIHC.Filter;

namespace trabalhoIHC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MessagesActionFilter());
        }
    }
}
