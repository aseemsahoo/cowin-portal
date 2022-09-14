using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cowin_Library.Users
{
    public class Districts
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}