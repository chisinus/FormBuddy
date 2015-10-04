using FormBuddyWeb.BusinessObjects;
using FormBuddyWeb.DAL;
using FormBuddyWeb.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormBuddyWeb.BusinessLogics
{
    public class MiscAgent : IMiscRepository
    {
        public List<SelectListItem> GetSecurityQuestions()
        {
            List<SelectListItem> ret;
            using (FBWDBContext context = new FBWDBContext())
            {
                ret = context.tblDict_SecurityQuestion.Select(sq => new SelectListItem { Text = sq.SecurityQuestion, Value = sq.SecurityQuestionID.ToString() }).ToList();
            }

            return ret;
        }
    }
}