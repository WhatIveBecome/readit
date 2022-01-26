﻿using System.ComponentModel.DataAnnotations;

namespace readit.Models
{
    public class GeneralModel
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
