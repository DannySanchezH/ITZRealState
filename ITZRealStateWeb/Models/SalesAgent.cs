using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITZRealStateWeb.Models
{
    public class SalesAgent
    {
        [Display(Name = "Amenitie Id")]
        public string IdAmenitie { get; set; }

        [Required]
        [Display(Name = "Amenitie Name")]
        public string name { get; set; }
    }
}