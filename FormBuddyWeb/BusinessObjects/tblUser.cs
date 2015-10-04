using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FormBuddyWeb.BusinessObjects
{
    public class tblUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserID { get; set; }
        public string EmailAddress { get; set; }
        public string Fristname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string PasswordSand { get; set; }
        public int StatusID { get; set; }
        public int SecurityQuestionID { get; set; }
        public string SecurityQuestionAnswer { get; set; }
        public int CurrentGroupID { get; set; }
    }
}