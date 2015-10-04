using FormBuddyWeb.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FormBuddyWeb.Tests.BusinessLogic_Repository
{
    class BLR_MiscAgent : IMiscRepository
    {
        public List<SelectListItem> GetSecurityQuestions()
        {
            List<SelectListItem> ret = new List<SelectListItem>()
            {
                new SelectListItem { Text="What was your childhood nickname?", Value="1" },
                new SelectListItem { Text="What school did you attend for sixth grade?", Value="2" },
                new SelectListItem { Text="What was your dream job as a child?", Value="3" },
                new SelectListItem { Text="What year did you graduate from High School?", Value="4" },
                new SelectListItem { Text="What was the color of your first car?", Value="5" }
            };

            return ret;
        }
    }
}
