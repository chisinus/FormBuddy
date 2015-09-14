using FormBuddyWeb.BusinessLogics;
using FormBuddyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FormBuddyWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel login)
        {
            if (!ModelState.IsValid) return View();

            if (UserAgent.ValidateUser(login))
            {
                var authTicket = new FormsAuthenticationTicket(
                      1,
                      login.UserName,
                      DateTime.Now,
                      DateTime.Now.AddMinutes(20),  // expiry
                      login.RememberMe,
                      "", //roles 
                      "/"
                    );

                //encrypt the ticket and add it to a cookie
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(authTicket));
                Response.Cookies.Add(cookie);

                return Redirect("UserHome");
            }

            ModelState.AddModelError("", "Incorrect username or password");

            return View();
        }

        public ActionResult Register(RegisterViewModel register)
        {
            return View();
        }
    }
}