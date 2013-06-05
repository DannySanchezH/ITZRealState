using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class Desire
    {
        [Key]
        public int IdDesire { get; set; }
        public int IdUser { get; set; }
        public int IdListing { get; set; }
    }
}