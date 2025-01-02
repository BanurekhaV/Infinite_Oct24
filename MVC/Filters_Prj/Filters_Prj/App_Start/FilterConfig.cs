using System.Web;
using System.Web.Mvc;
using Filters_Prj.Models;
using Filters_Prj.CustomFilter;

namespace Filters_Prj
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
             filters.Add(new HandleErrorAttribute());
            //filters.Add(new LogCustomExceptionFilter());
            //filters.Add(new AdminFilter());
        }
    }
}
