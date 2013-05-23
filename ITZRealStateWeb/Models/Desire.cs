using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITZRealStateWeb.Models
{
    public class Desire
    {
        [Display(Name = "User Id")]
        public int IdUser { get; set; }

        [Display(Name = "Amenitie Name")]
        public long IdListing { get; set; }
    }
}