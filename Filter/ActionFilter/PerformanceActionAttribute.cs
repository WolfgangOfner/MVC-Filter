using System.Diagnostics;
using System.Web.Mvc;

namespace Filter.ActionFilter
{
    public class PerformanceActionAttribute : FilterAttribute, IActionFilter
    {
        private Stopwatch _stopwatch;

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _stopwatch = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            _stopwatch.Stop();

            if (filterContext.Exception == null)
            {
                filterContext.HttpContext.Response.Write($"<p>The execution of the action took: {_stopwatch.Elapsed.TotalSeconds:F6} seconds</p>");
            }
        }
    }
}