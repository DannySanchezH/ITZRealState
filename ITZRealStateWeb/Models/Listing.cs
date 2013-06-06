using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITZRealStateWeb.Models
{
    public class Listing
    {
        [Display(Name = "Listing Id")]
        public int IdListing { get; set; }
        
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Lot Size")]
        public double lotSize { get; set; }

        [Required]
        [Display(Name = "Constructed Size")]
        public double constSize { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double price { get; set; }

        [Required]
        [Display(Name = "SaleAgent")]
        public int IdUser { get; set;}

        [Required]
        [Display(Name = "ZipCode")]
        public int zipcode { get; set; }
    }
}