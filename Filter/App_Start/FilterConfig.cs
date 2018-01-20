using System.Web.Mvc;
using Filter.ActionFilter;

namespace Filter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // register filter gloablly
            //filters.Add(new PerformanceActionAttribute());
        }
    }
}