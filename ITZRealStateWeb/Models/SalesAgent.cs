using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITZRealStateWeb.Models
{
    public class SalesAgent
    {
        [Display(Name = "SaleAgent ID")]
        public long IdUser { get; set; }

        [Display(Name = "Phone Number ")]
        public string phone { get; set; }

        [Display(Name = "Cellular Number")]
        public string cellular { get; set; }
    }
}