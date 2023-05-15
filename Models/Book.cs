using System.ComponentModel.DataAnnotations;

namespace Bookstore_MVC.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime CreatedAt { get; set;}
    }
}
