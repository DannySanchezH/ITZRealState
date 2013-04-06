using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class Listing
    {
        [Key]
        public long IdListing { get; set; }
        public string address { get; set; }
        public float lotSize { get; set; }
        public float constSize { get; set; }
        public float price { get; set; }
        public long IdUser { get; set;}
        public bool sold { get; set; }
    }
}