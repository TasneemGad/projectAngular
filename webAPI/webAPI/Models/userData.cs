﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webAPI.Models
{
    public class userData
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password")]
        public string confirmPassword { get; set; }
    }
}