using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.Models
{
        public class Book
        {
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "Title is required.")]
            public string Title { get; set; }

            [Required(ErrorMessage = "Author is required.")]
            public string Author { get; set; }

            [Required(ErrorMessage = "Price is required.")]
            [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
            public decimal Price { get; set; }

            [Required(ErrorMessage = "Cover Image URL is required.")]
            [Url(ErrorMessage = "Please enter a valid URL.")]
            public string CoverImageUrl { get; set; }

            [Required(ErrorMessage = "Category is required.")]
            public string Genre { get; set; }

            [Required(ErrorMessage = "Description is required.")]
            public string Description { get; set; }
        }
    }
