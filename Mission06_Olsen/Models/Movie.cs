﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Olsen.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]  // Foreign key attribute
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }  // Navigation property

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1888, int.MaxValue)]
        public int Year { get; set; }

    
        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex {  get; set; }

        [StringLength(25, ErrorMessage = "Notes must be at most 25 characters long")]
        public string? Notes { get; set; }


    }
}
