﻿using Microsoft.Build.Framework;

namespace SosMulheres.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
