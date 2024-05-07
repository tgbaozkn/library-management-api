using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required]
        public  string Name { get; set; }

        public  ICollection<Book> Books { get; set; }
    }
}