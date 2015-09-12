using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormBuddyWeb.Models
{
    public class LoginModel
    {
        [Display(Name ="User Name")]
        [Required]
        public string Username { get; set; }
        [Display(Name ="Password")]
        [Required]
        public string Password { get; set; }
    }
}