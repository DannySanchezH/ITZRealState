using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class Room_Listing
    {
        public int IdListing { get; set; }
        public int IdRoom{ get; set; }
        public float Amount { get; set; }
    }
}