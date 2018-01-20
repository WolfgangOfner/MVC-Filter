using System.Diagnostics;
using System.Web.Mvc;

namespace Filter.Controllers
{
    public class FilteringWithoutFilterController : Controller
    {
        private Stopwatch _stopwatch;

        public string Index()
        {
            return "This action measures the time from the start of the execution until the result is executed";
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _stopwatch = Stopwatch.StartNew();
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            _stopwatch.Stop();

            if (filterContext.Exception == null)
            {
                filterContext.HttpContext.
                    Response.Write($"<p>The execution of the action took: " +
                                   $"{_stopwatch.Elapsed.TotalSeconds:F6} seconds</p>");
            }
        }
    }
}