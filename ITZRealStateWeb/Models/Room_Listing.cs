using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITZRealStateWeb.Models
{
    public class Room_Listing
    {   
        [Display(Name = "Listing Id")]
        public int IdListing { get; set; }

        [Display(Name = "Room Id")]
        public int IdRoom { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public float amount { get; set; }
    }
}