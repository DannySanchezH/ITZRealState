using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class AmenitieListing
    {
        [Key]
        public long IdListing { get; set; }
        public int IdAmenitie { get; set; }
    }
}