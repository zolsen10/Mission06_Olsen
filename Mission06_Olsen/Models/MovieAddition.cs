using System.ComponentModel.DataAnnotations;

namespace Mission06_Olsen.Models
{
    public class MovieAddition
    {
        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Key]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Movie rating is required")]
        public string MovieRating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes must be at most 25 characters long")]
        public string Notes { get; set; }
    }
}
