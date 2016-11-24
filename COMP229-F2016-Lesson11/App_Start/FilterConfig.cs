using System.Web;
using System.Web.Mvc;

namespace COMP229_F2016_Lesson11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
