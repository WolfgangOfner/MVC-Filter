using System;
using System.Threading;
using System.Web.Mvc;
using Filter.ActionFilter;

namespace Filter.Controllers
{
    public class MyActionFilterController : Controller
    {
        [MyAction]
        public string Index()
        {
            return "You are not using Chrome";
        }

        [PerformanceAction]
        public string MeasureExecutionTime()
        {
            var test = new Random();
            Thread.Sleep(test.Next(0, 2000));

            return "The execution time of this execution is beeing measured";
        }
    }
}