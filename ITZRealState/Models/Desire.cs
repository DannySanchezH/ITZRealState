using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class Desire
    {
        [Key]
        public long IdUser { get; set; }
        public long IdListing { get; set; }
    }
}