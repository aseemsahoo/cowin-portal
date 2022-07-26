using System;
using System.Text.RegularExpressions;

namespace Cowin_Portal
{
    public class RegexValidation
    {
        private string FULLNAME_REGEX = "^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)";

        private string PHONENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";

        private string AADHAAR_REGEX = "^[2-9]{1}[0-9]{3}[0-9]{4}[0-9]{4}$";

        private string YEAR_REGEX = "^(194[5-9]|19[5-9]\\d|200\\d|201[0-3])$";

        private string USERNAME_REGEX = "^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$";

        private string PASSWORD_REGEX = "^(.{0,7}|[^0-9]*|[^A-Z]*|[^a-z]*|[a-zA-Z0-9]*)$";

        internal bool isValid_phonenumber(string text)
        {
            return Regex.IsMatch(text, PHONENUMBER_REGEX);
        }

        internal bool isValid_username(string text)
        {
            return Regex.IsMatch(text, USERNAME_REGEX);
        }

        internal bool isValid_password(string text)
        {
            if (Regex.IsMatch(text, PASSWORD_REGEX) == true)
                return false;
            return true;
        }
        internal bool isValid_fullname(string text)
        {
            return Regex.IsMatch(text, FULLNAME_REGEX);
        }

        internal bool isValid_birthyear(string text)
        {
            return Regex.IsMatch(text, YEAR_REGEX);
        }

        internal bool isValid_aadhaar(string text)
        {
            return Regex.IsMatch(text, AADHAAR_REGEX);
        }
    }
}