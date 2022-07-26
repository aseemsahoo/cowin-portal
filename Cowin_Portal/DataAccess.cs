using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;

namespace Cowin_Portal
{
    public class DataAccess
    {
        public static void ErrorLogging(Exception ex)
        {
            {
                var currentDate = DateTime.Now;
                var monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(currentDate.Month);

                var root = AppDomain.CurrentDomain.BaseDirectory + "\\logs";
                var yearPath = root + "\\" + currentDate.Year.ToString() + "\\";
                var MonthPath = yearPath + currentDate.Year + "-" + monthName + "\\";
                var errorFile = MonthPath + "ErrorLogs-" + String.Format("{0:d-M-yyyy}", currentDate.Date) + ".txt";
                
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                if (!Directory.Exists(yearPath))
                {
                    Directory.CreateDirectory(yearPath);
                }
                if (!Directory.Exists(MonthPath))
                {
                    Directory.CreateDirectory(MonthPath);
                }
                if (!File.Exists(errorFile))
                {
                    FileStream fs = File.Create(errorFile);
                    fs.Close();
                }
                using (StreamWriter sw = File.AppendText(errorFile))
                {
                    sw.WriteLine("=============Error Logging ===========");
                    sw.WriteLine("===========Start============= " + currentDate);
                    sw.WriteLine("<Error Message>: ");
                    sw.WriteLine(ex.Message);
                    sw.WriteLine("<Stack Trace>: ");
                    sw.WriteLine(ex.StackTrace);
                    sw.WriteLine("===========End============= " + currentDate);
                    sw.WriteLine();
                }
            }
        }

        internal bool test_connection()
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return false;
            }
        }

        internal List<User_Login> get_login_data(string u_name)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<User_Login>("dbo.get_login_data @username", new { username = u_name });
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        internal string get_username(int user_id)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<string>("dbo.get_username @userId", new { userId = user_id });
                    return output.ToList()[0];
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.Message;
            }
        }

        internal int get_register_status(int user_id)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new { userId = user_id };

                    var output = connection.Query<int>("dbo.get_register_status", p, commandType: CommandType.StoredProcedure);
                    return output.ToList()[0];
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.GetHashCode();
            }
        }

        internal string insert_user(string phone_no, string u_name, string pw, string _salt)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    User_SignIn curr_user = new User_SignIn
                    {
                        phonenumber = phone_no,
                        username = u_name,
                        password = pw,
                        salt = _salt
                    };
                    List<User_SignIn> user_insert = new List<User_SignIn>();
                    user_insert.Add(curr_user);

                    connection.Execute("dbo.insert_user @phonenumber, @username, @password, @salt", user_insert);
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.Message;
            }
        }

        internal string insert_user_register(int user_ID, string name, string gen, int yr, string aadhaar, string r_id)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    User_full_info curr_user = new User_full_info
                    {
                        user_id = user_ID,
                        fullname = name,
                        aadhaar_no = aadhaar,
                        ref_id = r_id,
                        gender = gen,
                        birth_year = yr
                    };
                    List<User_full_info> user_insert = new List<User_full_info>();
                    user_insert.Add(curr_user);

                    connection.Execute("dbo.insert_user_register @user_id, @fullname, @aadhaar_no, @ref_id, @gender, @birth_year", user_insert);
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.Message;
            }
        }

        internal List<States> get_all_states()
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<States>("dbo.get_states");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        internal List<User_full_info> get_full_details(int userID)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<User_full_info>("dbo.get_user_dashboard_info @userId", new { userId = userID });
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        internal List<User_dose_data> get_all_doses(int userID)
        {
            try
            {
                using (var connection =
                    new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new { userId = userID };

                    var output = connection.Query<User_dose_data>("dbo.get_dose_info @userId", p);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        internal List<Hospital> search_center(int district_index, int vaccine_index, int _age_limit)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new
                    {
                        district_id = district_index,
                        vaccine_id = vaccine_index,
                        age_limit = _age_limit
                    };
                    var output = connection.Query<Hospital>("dbo.get_centers @district_id, @vaccine_id, @age_limit", p);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        internal List<Districts> get_districts(int stateID)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<Districts>("dbo.get_districts @state_id", new { state_id = stateID });
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        internal List<int> get_dose1_vaccine(int user_id)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<int>("dbo.get_dose1_vaccine @userId", new { userId = user_id });
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        internal List<int> get_dose1_age(int user_id)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<int>("dbo.get_dose1_age @userId", new { userId = user_id });
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        internal List<DateTime> get_dose1_date(int user_id)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<DateTime>("dbo.get_dose1_date @userId", new { userId = user_id });

                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return null;
            }
        }

        internal string insert_user_dose_data(int user_id, int hospital_id, string date, string time, int dose_type)
        {

            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@userId", user_id);
                    p.Add("@centerId", hospital_id);
                    p.Add("@date", date);
                    p.Add("@time", time);

                    if (dose_type == 0)
                    {
                        connection.Execute("dbo.insert_user_dose1", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                    if (dose_type == 1)
                    {
                        connection.Execute("dbo.insert_user_dose2", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                    {
                        connection.Execute("dbo.insert_user_dose_precaution", p, commandType: CommandType.StoredProcedure);
                    }
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.Message;
            }
        }
    }
}