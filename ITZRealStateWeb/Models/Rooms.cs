using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITZRealStateWeb.Models
{
    public class Room
    {
        [Display(Name = "Room Id")]
        public int IdRoom { get; set; }

        [Required]
        [Display(Name = "Room Type")]
        public string type { get; set; }

    }
}