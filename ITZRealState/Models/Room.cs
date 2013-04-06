using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class Room
    {
        [Key]
        public int IdRoom { get; set; }
        public string type { get; set; }
    }
}