using FormBuddyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace FormBuddyWeb.Controllers.api
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public ActionResult ValidateUser(LoginModel login)
        {
            return View();
        }
    }
}