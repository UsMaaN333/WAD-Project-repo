﻿using System.ComponentModel.DataAnnotations;

namespace WAD_SRMS_Project.models
{
    public class loginModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Password { get; set; }
    }
}