using System;

namespace Cowin_Portal
{
    public class RegexValidation
    {
        public string FULLNAME_REGEX = "^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)";

        public string PHONENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";

        public string AADHAAR_REGEX = "^[2-9]{1}[0-9]{3}[0-9]{4}[0-9]{4}$";

        public string YEAR_REGEX = "^(194[5-9]|19[5-9]\\d|200\\d|201[0-3])$";

        public string USERNAME_REGEX = "^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$";

        public string PASSWORD_REGEX = "^(.{0,7}|[^0-9]*|[^A-Z]*|[^a-z]*|[a-zA-Z0-9]*)$";
    }
}
