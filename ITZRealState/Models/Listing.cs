using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class Listing
    {
        [Key]
        public long IdListing { get; set; }
        public string street { get; set; }
        public string number { get; set; }
        public string colony { get; set; }
        public double lotSize { get; set; }
        public double constSize { get; set; }
        public double price { get; set; }
        public long IdUser { get; set;}
        public bool sold { get; set; }
        public int zipcode { get; set; }
    }
}