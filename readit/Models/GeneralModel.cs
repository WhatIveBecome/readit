﻿using System.ComponentModel.DataAnnotations;

namespace readit.Models
{
    public class GeneralModel
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public IEnumerable<ReplyModel> Replies { get; set; }
        //public ReplyModel Reply { get; set; }
    }
}
