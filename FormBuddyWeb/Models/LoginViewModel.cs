﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormBuddyWeb.Models
{
    public class LoginViewModel
    {
        [Display(Name ="User Name")]
        [Required]
        public string UserName { get; set; }

        [Display(Name ="Password")]
        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}