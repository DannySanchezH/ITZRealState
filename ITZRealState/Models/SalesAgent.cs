using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class SalesAgent
    {
        [Key]
        public long IdUser { get; set; }
        public string phone { get; set; }
        public string cellular { get; set; }
    }
}