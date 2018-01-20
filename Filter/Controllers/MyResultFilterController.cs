using System.Web.Mvc;
using Filter.ResultFilter;

namespace Filter.Controllers
{
    public class MyResultFilterController : Controller
    {
        [MyResultFilter]
        public string Index()
        {
            return "The execution of the result is beeing measured";
        }
    }
}