using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormBuddyWeb.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength =6, ErrorMessage = "Password must be at least 6 charactors")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public int SecurityQuestionID { get; set; }
        [Required]
        [StringLength(100)]
        public string SecurityQuestionAnswer { get; set; }
    }
}