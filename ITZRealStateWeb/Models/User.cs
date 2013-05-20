using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITZRealStateWeb.Models
{
    public class User
    {
        [Display(Name = "User Id")]
        public long IdUser { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string lastName { get; set; }


        [Display(Name = "Facebook")]
        public string facebookId { get; set; }

        [Display(Name = "ZipCode")]
        public int zipCode { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Access Token")]
        public string accesstoken { get; set; }

    }
}