using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vehicle.webclient.Models
{
    public class LogInModel
    {
        [Required]
        [Display(Name = "Username:")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password:")]
        public string Password { get; set; }
    }

}