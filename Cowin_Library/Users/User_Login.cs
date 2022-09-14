using System.ComponentModel.DataAnnotations;

namespace Cowin_Library.Users
{
    public class User_Login
    {
        [Key]
        public int id { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
    }
}