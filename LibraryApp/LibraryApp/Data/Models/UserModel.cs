using LibraryApp.Enums;
using System.Data;

namespace LibraryApp.Data.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
