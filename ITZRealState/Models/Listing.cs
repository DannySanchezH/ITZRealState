using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class Listing
    {
        
        public int IdListing { get; set; }
        public string Address { get; set; }
        public double lotSize { get; set; }
        public double constSize { get; set; }
        public double price { get; set; }
        public int IdUser { get; set;}
        public int zipcode { get; set; }
    }
}