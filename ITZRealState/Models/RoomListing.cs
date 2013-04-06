using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class RoomListing
    {
        [Key]
        public long IdListing { get; set; }
        public int IdRoom { get; set; }
    }
}