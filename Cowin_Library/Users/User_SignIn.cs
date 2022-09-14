using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cowin_Library.Users
{
    public class User_SignIn : User_Login
    {
        public string phonenumber { get; set; }
        public string username { get; set; }
    }
}