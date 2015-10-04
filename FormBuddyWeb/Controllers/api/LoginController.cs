using FormBuddyWeb.BusinessLogics;
using FormBuddyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FormBuddyWeb.Controllers.api
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public bool ValidateUser(LoginViewModel login)
        {
            //return UserAgent.ValidateUser(login);
            return true;
        }
    }
}