using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class BooksModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } = null;
        public string? Author { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
