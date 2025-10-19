using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class AddBookModel
    {
        [Required(ErrorMessage = "Название книги обязательно")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Длина названия от 3 до 100 символов")]
        public string Name { get; set; }
        public string? Description { get; set; } = null;
        public string? Author { get; set; }

        [Required(ErrorMessage = "Категория обязательна")]
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
