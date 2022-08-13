using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Cowin_API.Models
{
    public class DataAccess
    {
        private string conStr_remote, conStr_local;
        private string conStr;
        public DataAccess()
        {
            conStr_remote = "Data Source=SQL8004.site4now.net;Initial Catalog=db_a8aadf_cowindatabase;User Id=db_a8aadf_cowindatabase_admin;Password=aseemS30!";
            //conStr_remote = @"Data Source = sql8004.site4now.net; Network Library = DBMSSOCN; Initial Catalog = db_a8aadf_cowindatabase; User ID = db_a8aadf_cowindatabase_admin; Password = aseemS30!;";
            conStr_local = @"Server=localhost;Initial Catalog=cowin_database;User Id=guest;Password=root123;";
            conStr = conStr_remote;
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

        internal bool test_connection(int num)
        {
            try
            {
                if (num == 1)
                    conStr = conStr_local;
                else
                    conStr = conStr_remote;
                using (IDbConnection conn = connection)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return false;
            }
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
                    p.Add("@user_id", user_id);

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

        internal string insert_user(User_SignIn curr_user)
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    connection.Execute("dbo.insert_user @phonenumber, @username, @password, @salt", curr_user);
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
                    connection.Execute("dbo.insert_user_register @user_id, @fullname, @aadhaar_no, @ref_id, @gender, @birth_year", user);
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
                    p.Add("@user_id", userID);

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
                    p.Add("@user_id", userID);

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

        internal string insert_user_dose_data(User_dose_input curr_dose)
        {
            try
            {
                using (IDbConnection conn = connection)
                {
                    if (curr_dose.dose_type == 0)
                    {
                        connection.Execute("dbo.insert_user_dose1 @user_id, @centerId, @date, @time", curr_dose);
                    }
                    else
                    if (curr_dose.dose_type == 1)
                    {
                        connection.Execute("dbo.insert_user_dose2 @user_id, @centerId, @date, @time", curr_dose);
                    }
                    else
                    {
                        connection.Execute("dbo.insert_user_dose_precaution @user_id, @centerId, @date, @time", curr_dose);
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
