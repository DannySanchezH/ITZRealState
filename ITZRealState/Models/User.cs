using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITZRealState.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string firstName { get; set; }
        public string lastName{ get; set; }
        public string facebookId { get; set; }
        public int zipCode { get; set;}
        public string email { get; set; }
        public string accesstoken { get; set; }
    }
}