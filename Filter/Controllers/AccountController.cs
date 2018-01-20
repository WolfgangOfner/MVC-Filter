using System.Web.Mvc;
using System.Web.Security;

namespace Filter.Controllers
{
    //[Authorize]
    //[Authorize(Roles = "user")] // applies to all actions
    public class AccountController : Controller
    {
        //[Authorize] // applies only to this action
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string returnUrl)
        {
            var result = Membership.ValidateUser(username, password);

            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);

                return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
            }

            ModelState.AddModelError("", "Incorrect username or password");

            return View();
        }
    }
}