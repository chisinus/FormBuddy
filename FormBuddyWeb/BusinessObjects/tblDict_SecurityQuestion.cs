using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormBuddyWeb.BusinessObjects
{
    public class tblDict_SecurityQuestion
    {
        [Key]
        public int SecurityQuestionID { get; set; }
        public string SecurityQuestion { get; set; }
    }
}