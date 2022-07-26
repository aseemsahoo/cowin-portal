using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading.Tasks;
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
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
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
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_username", u_name);

                    var output = connection.Query<User_Login>("dbo_get_login_data", p, commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal string get_username(int user_id)
        {
            try
            {
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_userId", user_id);

                    var output = connection.Query<string>("dbo_get_username", p, commandType: CommandType.StoredProcedure).ToList();
                    return output[0];
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
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_userId", user_id);

                    var output = connection.Query<int>("dbo_get_register_status", p, commandType: CommandType.StoredProcedure).ToList();
                    return output[0];
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.HResult;
            }
        }

        internal string insert_user(string phone_no, string u_name, string pw, string _salt)
        {
            try
            {
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_phonenumber", phone_no);
                    p.Add("p_username", u_name);
                    p.Add("p_password", pw);
                    p.Add("p_salt", _salt);

                    connection.Execute("dbo_insert_user", p, commandType: CommandType.StoredProcedure);
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
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_userId", user_ID);
                    p.Add("p_fullname", name);
                    p.Add("p_aadhaar_no", aadhaar);
                    p.Add("p_ref_id", r_id);
                    p.Add("p_gender", gen);
                    p.Add("p_birth_year", yr);

                    connection.Execute("dbo_insert_user_register", p, commandType: CommandType.StoredProcedure);
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
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<States>("dbo_get_states").ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal List<User_full_info> get_full_details(int userID)
        {
            try
            {
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_userId", userID);

                    var output = connection.Query<User_full_info>("dbo_get_user_dashboard_info", p, commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal List<User_dose_data> get_all_doses(int userID)
        {
            try
            {
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_userId", userID);

                    var output = connection.Query<User_dose_data>("dbo_get_dose_info", p, commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal List<Hospital> search_center(int district_index, int vaccine_index, int _age_limit)
        {
            try
            {
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_district_id", district_index);
                    p.Add("p_vaccine_id", vaccine_index);
                    p.Add("p_age_limit", _age_limit);

                    var output = connection.Query<Hospital>("dbo_get_centers", p, commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal List<Districts> get_districts(int stateID)
        {
            try
            {
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_state_id", stateID);

                    var output = connection.Query<Districts>("dbo_get_districts", p, commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal List<int> get_dose1_vaccine(int user_id)
        {
            try
            {
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_userId", user_id);

                    var output = connection.Query<int>("dbo_get_dose1_vaccine", p, commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal List<int> get_dose1_age(int user_id)
        {
            try
            {
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_userId", user_id);

                    var output = connection.Query<int>("dbo_get_dose1_age", p, commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal List<DateTime> get_dose1_date(int user_id)
        {
            try
            {
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_userId", user_id);

                    var output = connection.Query<DateTime>("dbo_get_dose1_date", p, commandType: CommandType.StoredProcedure).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal string insert_user_dose_data(int user_id, int hospital_id, string date, string time, int dose_type)
        {
            try
            {
                using (var connection = new MySqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("p_userId", user_id);
                    p.Add("p_centerId", hospital_id);
                    p.Add("p_date", date);
                    p.Add("p_time", time);

                    if (dose_type == 0)
                    {
                        connection.Execute("dbo_insert_user_dose1", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                    if (dose_type == 1)
                    {
                        connection.Execute("dbo_insert_user_dose2", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                        connection.Execute("dbo_insert_user_dose_precaution", p, commandType: CommandType.StoredProcedure);

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