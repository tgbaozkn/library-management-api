using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public required Author Author { get; set; }

        public int PublisherId { get; set; }
        public required Publisher Publisher { get; set; }
    }
}