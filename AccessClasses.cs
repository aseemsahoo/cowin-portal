using System;

public class User_Login
{
    public int id { get; set; }
    public string password { get; set; }
    public string salt { get; set; }
}
public class User_SignIn : User_Login
{
    public string phonenumber { get; set; }
    public string username { get; set; }
}
public class User_full_info
{
    public int user_id { get; set; }
    public string fullname { get; set; }
    public string gender { get; set; }
    public string ref_id { get; set; }
    public string aadhaar_no { get; set; }
    public int birth_year { get; set; }
}
public class User_dose_data
{
    public string vaccine_name { get; set; }
    public string hospital_name { get; set; }
    public int age_limit { get; set; }
    public DateTime dose_date { get; set; }
    public string district_name { get; set; }
    public string state_name { get; set; }
}
public class User_dose_input
{
    public int user_id { get; set; }
    public int centerId { get; set; }
    public string date { get; set; }
    public string time { get; set; }
    public int dose_type { get; set; }
}

public class States
{
    public int id { get; set; }
    public string name { get; set; }
}

public class Districts
{
    public int id { get; set; }
    public string name { get; set; }
}

public class Hospital
{
    [Browsable(false)]
    public int id { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public string vaccine { get; set; }
}
