using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;

namespace Cowin_Portal
{
    public class DataAccess
    {   
        public int get_login_status(string u_name, string pw)
        {
            try
            {
                using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@username", u_name);
                    p.Add("@password", pw);
                    p.Add("@result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute
                        ("dbo.get_login_status", p, commandType: CommandType.StoredProcedure);
                    var retVal = p.Get<int>("@result");
                    return retVal;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public string get_username(int user_id)
        {
            try
            {
                using (IDbConnection connection =
                    new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<string>("dbo.get_username @userId", new { userId = user_id }).ToList();
                    return output[0];
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool get_register_status(int user_id)
        {

            try
            {
                using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@userID", user_id);
                    p.Add("@result", dbType: DbType.Boolean, direction: ParameterDirection.Output);

                    connection.Execute
                        ("dbo.get_register_status", p, commandType: CommandType.StoredProcedure);
                    bool retVal = p.Get<bool>("@result");
                    return retVal;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string insert_user(string phone_no, string u_name, string pw)
        {
            try
            {
                using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    User_SignIn curr_user = new User_SignIn
                    {
                        phonenumber = phone_no,
                        username = u_name,
                        password = pw
                    };
                    List<User_SignIn> user_insert = new List<User_SignIn>();
                    user_insert.Add(curr_user);
                    connection.Execute("dbo.insert_user @phonenumber, @username, @password", user_insert);
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        
        public string insert_user_register(int user_ID, string name, string gen, int yr, string aadhaar, string r_id)
        {
            try
            {
                using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    User_full_info curr_user = new User_full_info
                    {
                        userID = user_ID,
                        fullname = name,
                        aadhaar_no = aadhaar,
                        ref_id = r_id,
                        gender = gen,
                        birth_year = yr
                    };
                    List<User_full_info> user_insert = new List<User_full_info>();
                    user_insert.Add(curr_user);
                    connection.Execute("dbo.insert_user_register @userID, @fullname, @aadhaar_no, @ref_id, @gender, @birth_year", user_insert);
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<States> get_all_states()
        {
            try
            {
                using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<States>("dbo.get_states");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<User_full_info> get_full_details(int userID)
        {
            try
            {
                using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<User_full_info>("dbo.get_user_dashboard_info @userId", new { userId = userID });
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<User_dose_data> get_all_doses(int userID)
        {
            try
            {
                using (IDbConnection connection =
                    new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    // change dose type to 0
                    var d0 = new { userId = userID, dose_type = 0 };
                    var d1 = new { userId = userID, dose_type = 1 };
                    var d2 = new { userId = userID, dose_type = 2 };
                    var list1 = connection.Query<User_dose_data>("dbo.get_dose_info @userId, @dose_type", d0).ToList();
                    var list2 = connection.Query<User_dose_data>("dbo.get_dose_info @userId, @dose_type", d1).ToList();
                    var list3 = connection.Query<User_dose_data>("dbo.get_dose_info @userId, @dose_type", d2).ToList();

                    list2.AddRange(list3);
                    list1.AddRange(list2);
                    return list1;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Hospital> search_center(int district_index, int vaccine_index, int _age_limit)
        {
            try
            {
                using (IDbConnection connection =
                    new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new
                    {
                        district_id = district_index,
                        vaccine_id = vaccine_index,
                        age_limit = _age_limit
                    };
                    var output = connection.Query<Hospital>("dbo.get_centers @district_id, @vaccine_id, @age_limit", p).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Districts> get_districts(int stateID)
        {
            try
            {
                using (IDbConnection connection =
                    new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<Districts>("dbo.get_districts @state_id", new { state_id = stateID }).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<int> get_dose1_vaccine(int user_id)
        {
            try
            {
                using (IDbConnection connection =
                    new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<int>("dbo.get_dose1_vaccine @userId", new { userId = user_id }).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<int> get_dose1_age(int user_id)
        {
            try
            {
                using (IDbConnection connection =
                    new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<int>("dbo.get_dose1_age @userId", new { userId = user_id }).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<DateTime> get_dose1_date(int user_id)
        {
            try
            {
                using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var output = connection.Query<DateTime>("dbo.get_dose1_date @userId", new { userId = user_id }).ToList();

                    return output;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string insert_user_dose_data(int user_id, int hospital_id, string date, string time, int dose_type)
        {

            try
            {
                using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectDB")))
                {
                    var p = new DynamicParameters();
                    p.Add("@userID", user_id);
                    p.Add("@centerID", hospital_id);
                    p.Add("@date", date);
                    p.Add("@time", time);

                    if(dose_type == 0)
                    {
                        connection.Execute("dbo.insert_user_dose1", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                    if (dose_type == 1)
                    {
                        connection.Execute("dbo.insert_user_dose2", p, commandType: CommandType.StoredProcedure);
                    }
                    else
                        connection.Execute("dbo.insert_user_dose_precaution", p, commandType: CommandType.StoredProcedure);

                    return "OK";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}