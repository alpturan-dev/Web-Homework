﻿using System;
using System.ComponentModel.DataAnnotations;
namespace Web_Homework.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

    }
}

