using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class Amenitie
    {
        [Key]
        public int IdAmenitie { get; set; }
        public string name { get; set; }
    }
}