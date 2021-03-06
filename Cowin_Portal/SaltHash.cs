using System;
using System.Collections.Generic;
using System.Text;
using BCrypt.Net;

namespace Cowin_Portal
{
    public class SaltHash
    {
        internal string GetSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt();
        }

        internal string Hash(string input, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(input, salt);
        }

        internal bool Verify(string password_input, string hashed_password)
        {
            return BCrypt.Net.BCrypt.Verify(password_input, hashed_password);
        }
    }
}
