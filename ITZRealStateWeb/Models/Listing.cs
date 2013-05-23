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
        public long IdListing { get; set; }
        
        [Required]
        [Display(Name = "Street")]
        public string street { get; set; }

        [Required]
        [Display(Name = "Number")]
        public string number { get; set; }

        [Required]
        [Display(Name = "Colony")]
        public string colony { get; set; }

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
        public long IdUser { get; set;}

        [Required]
        [Display(Name = "Sold")]
        public bool sold { get; set; }

        [Required]
        [Display(Name = "ZipCode")]
        public int zipcode { get; set; }
    }
}