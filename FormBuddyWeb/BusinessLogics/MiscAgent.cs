using FormBuddyWeb.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormBuddyWeb.BusinessLogics
{
    public class MiscAgent : IMiscRepository
    {
        public IEnumerable<SelectListItem> SecurityQuestions
        {
            get
            {
                // get from db
                return null;
            }
        }

        // is this necessary if we have above property?
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