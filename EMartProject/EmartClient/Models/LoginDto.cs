﻿using System.ComponentModel.DataAnnotations;

namespace EMartClient.Models
{
    public class LoginDto
    {

        [EmailAddress ]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}