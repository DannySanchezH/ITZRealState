﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class User
    {
        [Key]
        public long IdUser { get; set; }
        public string firstName { get; set; }
        public string lastName{ get; set; }
        public string userName { get; set; }
        public string facebookId { get; set; }
        public int zipCode { get; set;}
        public string email { get; set; }
    }
}