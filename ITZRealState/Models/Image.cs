using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class Image
    {
        [Key]
        public long IdListing { get; set; }
        public string source { get; set; }
    }
}