﻿using Cowin_API.Logging;
using Cowin_Library.Users;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Cowin_API.Models
{
    public class API_DataAccess
    {
        private IConfiguration _configuration;

        private string conStr;
        public API_DataAccess()
        {
            _configuration = GetConfiguration();
            conStr = this._configuration.GetConnectionString("Local");
        }

        private IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }

        public IDbConnection connection
        {
            get
            {
                return new SqlConnection(conStr);
            }
        }

        internal bool test_connection(int num)
        {
            try
            {
                if (num == 1)
                    conStr = this._configuration.GetConnectionString("Local");
                else
                    conStr = this._configuration.GetConnectionString("Global");
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                //return ex.GetHashCode();
                throw;
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                //return ex.Message;
                throw;
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                //return ex.Message;
                throw;
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
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
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                //return ex.Message;
                throw; 
            }
        }
    }
}
