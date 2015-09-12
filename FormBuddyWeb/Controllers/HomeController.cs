using FormBuddyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Index(LoginModel login)
        {
            if (UserAgent.ValidateUser(login))
                Redirect("");

            ModelState.AddModelError("NotMatch", "The user name and password do not match.");
        }
    }
}