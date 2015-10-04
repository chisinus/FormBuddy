using FormBuddyWeb.BusinessLogics;
using FormBuddyWeb.BusinessObjects;
using FormBuddyWeb.Interfaces;
using FormBuddyWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FormBuddyWeb.Controllers
{
    public class HomeController : Controller
    {
        IMiscRepository miscRepo;
        IUserRepository userRepo;

        public HomeController(IUserRepository userRepo, IMiscRepository miscRepo)
        {
            this.userRepo = userRepo;
            this.miscRepo = miscRepo;
        }

        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel login)
        {
            if (!ModelState.IsValid) return View();

            if (!userRepo.ValidateUser(login))
            {
                ModelState.AddModelError("", "Incorrect username or password");

                return View();
            }

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

        [HttpGet]
        public ViewResult Register()
        {
            ViewBag.SecurityQuestions = miscRepo.GetSecurityQuestions();

            return View();
        }

        [HttpPost]
        public ViewResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.SecurityQuestions = miscRepo.GetSecurityQuestions();
                return View();
            }

            return View("Register_Confirm", register);
        }
    }
}