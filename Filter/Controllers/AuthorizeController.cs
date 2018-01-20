using System.Web.Mvc;

namespace Filter.Controllers
{
    [Authorize]
    public class AuthorizeController : Controller
    {
        [Authorize(Roles = "Admin")]
        public ActionResult DoAdminStuff()
        {
            return View();
        }
    }
}