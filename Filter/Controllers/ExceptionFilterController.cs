using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Filter.Controllers
{
    public class ExceptionFilterController : Controller
    {
        //[HandleError] // redirects to Error/ErrorMessage (set in web.config) because no Index view exists
        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "ErrorMessage")]
        public ActionResult Index()
        {
            var value = new List<int>()[1];

            return View();
        }
    }
}