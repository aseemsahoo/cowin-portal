﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading.Tasks;

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

        internal async Task<List<User_Login>> get_login_data(string u_name)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@username", u_name);

                    var output = await connection.QueryAsync<User_Login>("dbo.get_login_data", p, commandType: CommandType.StoredProcedure);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal async Task<int> get_register_status(int user_id)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@userId", user_id);

                    var output = await connection.QueryAsync<int>("dbo.get_register_status", p, commandType: CommandType.StoredProcedure);
                    return output.ToList()[0];
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.GetHashCode();
            }
        }

        internal async Task<string> insert_user(string phone_no, string u_name, string pw, string _salt)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@phonenumber", phone_no);
                    p.Add("@username", u_name);
                    p.Add("@password", pw);
                    p.Add("@salt", _salt);

                    await connection.ExecuteAsync("dbo.insert_user", p, commandType: CommandType.StoredProcedure);
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.Message;
            }
        }

        internal async Task<string> insert_user_register(int user_ID, string name, string gen, int yr, string aadhaar, string r_id)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@userId", user_ID);
                    p.Add("@fullname", name);
                    p.Add("@aadhaar_no", aadhaar);
                    p.Add("@ref_id", r_id);
                    p.Add("@gender", gen);
                    p.Add("@birth_year", yr);

                    await connection.ExecuteAsync("dbo.insert_user_register", p, commandType: CommandType.StoredProcedure);
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                return ex.Message;
            }
        }

        internal async Task<List<Districts>> get_districts(int stateID)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@state_id", stateID);

                    var output = await connection.QueryAsync<Districts>("dbo.get_districts", p, commandType: CommandType.StoredProcedure);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal async Task<List<States>> get_all_states()
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = await connection.QueryAsync<States>("dbo.get_states");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal async Task<List<User_full_info>> get_full_details(int userID)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@userId", userID);

                    var output = await connection.QueryAsync<User_full_info>("dbo.get_user_dashboard_info", p, commandType: CommandType.StoredProcedure);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal async Task<List<User_dose_data>> get_all_doses(int userID)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@userId", userID);

                    var output = await connection.QueryAsync<User_dose_data>("dbo.get_dose_info", p, commandType: CommandType.StoredProcedure);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }

        internal async Task<List<Hospital>> search_center(int district_index, int vaccine_index, int _age_limit)
        {
            try
            {
                using (var connection = new SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@district_id", district_index);
                    p.Add("@vaccine_id", vaccine_index);
                    p.Add("@age_limit", _age_limit);

                    var output = await connection.QueryAsync<Hospital>("dbo.get_centers", p, commandType: CommandType.StoredProcedure);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                throw;
            }
        }
        
        internal async Task<string> insert_user_dose_data(int user_id, int hospital_id, string date, string time, int dose_type)
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
                        await connection.ExecuteAsync("dbo.insert_user_dose1", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                    if (dose_type == 1)
                    {
                        await connection.ExecuteAsync("dbo.insert_user_dose2", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                    {
                        await connection.ExecuteAsync("dbo.insert_user_dose_precaution", p, commandType: CommandType.StoredProcedure);
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