using FormBuddyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBuddyWeb.Interfaces
{
    public interface IUserRepository
    {
        bool ValidateUser(LoginViewModel login);
        int CreateUser(RegisterViewModel user);
    }
}
