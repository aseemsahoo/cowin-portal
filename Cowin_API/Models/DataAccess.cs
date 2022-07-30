using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Cowin_API.Models
{
    public class DataAccess
    {
        private string conStr;
        public DataAccess()
        {
            conStr = @"Server=localhost;Database=cowin_database;User Id=guest;Password=root123;";
        }
        public IDbConnection connection
        {
            get
            {
                return new SqlConnection(conStr);
            }
        }

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
            return true;
            // do this
        }

        internal IEnumerable<User_Login> get_login_data(string u_name)
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    var p = new DynamicParameters();
                    p.Add("@username", u_name);

                    var output = connection.Query<User_Login>("dbo.get_login_data", p, commandType: CommandType.StoredProcedure);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal int get_register_status(int user_id)
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    var p = new DynamicParameters();
                    p.Add("@userId", user_id);

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

        internal string insert_user(string phone_no, string u_name, string pw, string salt)
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    var p = new DynamicParameters();
                    p.Add("@phonenumber", phone_no);
                    p.Add("@username", u_name);
                    p.Add("@password", pw);
                    p.Add("@salt", salt);

                    connection.Execute("dbo.insert_user", p, commandType: CommandType.StoredProcedure);
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.Message;
            }
        }

        internal string insert_user_register(User_full_info user)
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    var p = new DynamicParameters();
                    p.Add("@userId", user.user_id);
                    p.Add("@fullname", user.fullname);
                    p.Add("@aadhaar_no", user.aadhaar_no);
                    p.Add("@ref_id", user.ref_id);
                    p.Add("@gender", user.gender);
                    p.Add("@birth_year", user.birth_year);

                    connection.Execute("dbo.insert_user_register", p, commandType: CommandType.StoredProcedure);
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.Message;
            }
        }

        internal IEnumerable<Districts> get_districts(int stateID)
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    var p = new DynamicParameters();
                    p.Add("@state_id", stateID);

                    var output = connection.Query<Districts>("dbo.get_districts", p, commandType: CommandType.StoredProcedure);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal IEnumerable<States> get_all_states()
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    var output = connection.Query<States>("dbo.get_states");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal IEnumerable<User_full_info> get_full_details(int userID)
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    var p = new DynamicParameters();
                    p.Add("@userId", userID);

                    var output = connection.Query<User_full_info>("dbo.get_user_dashboard_info", p, commandType: CommandType.StoredProcedure);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal IEnumerable<User_dose_data> get_all_doses(int userID)
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    var p = new DynamicParameters();
                    p.Add("@userId", userID);

                    var output = connection.Query<User_dose_data>("dbo.get_dose_info", p, commandType: CommandType.StoredProcedure);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal IEnumerable<Hospital> search_center(int district_index, int vaccine_index, int age_limit)
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    var p = new DynamicParameters();
                    p.Add("@district_id", district_index);
                    p.Add("@vaccine_id", vaccine_index);
                    p.Add("@age_limit", age_limit);

                    var output = connection.Query<Hospital>("dbo.get_centers", p, commandType: CommandType.StoredProcedure);
                    return output.ToList();
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
                using (IDbConnection conn = connection)
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
