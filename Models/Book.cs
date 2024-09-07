using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Edition { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public ICollection<Reader> Reader { get; set; }
    }
}
