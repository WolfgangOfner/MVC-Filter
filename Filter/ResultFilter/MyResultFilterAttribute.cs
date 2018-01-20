using System.Diagnostics;
using System.Web.Mvc;

namespace Filter.ResultFilter
{
    public class MyResultFilterAttribute : FilterAttribute, IResultFilter
    {
        private Stopwatch _stopwatch;

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            _stopwatch = Stopwatch.StartNew();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            _stopwatch.Stop();

            if (filterContext.Exception == null)
            {
                filterContext.HttpContext.
                    Response.Write($"<p>The execution of " +
                                   $"the result took: {_stopwatch.Elapsed.TotalSeconds:F6} seconds</p>");
            }
        }
    }
}