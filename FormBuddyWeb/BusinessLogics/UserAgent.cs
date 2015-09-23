using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormBuddyWeb.Models;
using FormBuddyWeb.Interfaces;

namespace FormBuddyWeb.BusinessLogics
{
    public class UserAgent : IUserRepository
    {
        public int CreateUser(RegisterViewModel user)
        {
            throw new NotImplementedException();
        }

        public bool ValidateUser(LoginViewModel login)
        {
            return true;
        }
    }
}