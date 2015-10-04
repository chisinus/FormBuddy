using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FormBuddyWeb.Interfaces
{
    public interface IMiscRepository
    {
        //IEnumerable<SelectListItem> SecurityQuestions { get; }

        List<SelectListItem> GetSecurityQuestions();
    }
}
