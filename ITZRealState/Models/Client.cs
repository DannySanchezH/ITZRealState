using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class Client
    {
        [Key]
        public long IdUser { get; set; }
    }
}