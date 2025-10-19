using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Data.Models
{
    public class BookModel: BaseModel
    {
        public string Name { get; set; }
        public string? Description { get; set; } = null;
        public string? Author { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
