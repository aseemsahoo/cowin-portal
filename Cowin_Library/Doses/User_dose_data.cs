using System;

namespace Cowin_Library.Users
{
    public class User_dose_data
    {
        public string vaccine_name { get; set; }
        public string hospital_name { get; set; }
        public int age_limit { get; set; }
        public DateTime dose_date { get; set; }
        public string district_name { get; set; }
        public string state_name { get; set; }
    }
}