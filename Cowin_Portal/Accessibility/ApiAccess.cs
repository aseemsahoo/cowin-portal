﻿using Cowin_Library.Logging;
using Cowin_Library.Users;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace Cowin_Portal.Accessibility
{
    /*
    public class UntrustedCertClientFactory : DefaultHttpClientFactory
    {
        public override HttpMessageHandler CreateMessageHandler()
        {
            return new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (_, _, _, _) => true
            };
        }
    }
    */
    public class ApiAccess
    {
        private string base_url = "https://localhost:5001/api/Cowin/";
        internal async Task<bool> test_connection(int status)
        {
            try
            {
                var url = base_url.AppendPathSegments("getconnection", status);
                var output = await url.GetJsonAsync<bool>();
                return output;
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                return false;
            }
        }

        internal async Task<List<User_Login>> get_login_data(string u_name)
        {
            try
            {
                var url = base_url.AppendPathSegments("getuser", u_name);
                var output = await url.GetJsonAsync<List<User_Login>>();
                return output;
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                throw;
            }
        }

        internal async Task<int> get_register_status(int user_id)
        {
            try
            {
                var url = base_url.AppendPathSegments("Getregisterstatus", user_id);
                var output = await url.GetJsonAsync<int>();
                return output;
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                throw;
            }
        }

        internal async Task<string> insert_user(User_SignIn curr_user)
        {
            try
            {
                var url = base_url.AppendPathSegments("PostUser");
                var output = await url.PostJsonAsync(curr_user);
                return "OK";
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                throw;
            }
        }

        internal async Task<string> insert_user_register(User_full_info curr_user)
        {
            try
            {
                var url = base_url.AppendPathSegments("PostRegisteredUser");
                var output = await url.PostJsonAsync(curr_user);
                return "OK";
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                throw;
            }
        }

        internal async Task<List<Districts>> get_districts(int stateID)
        {
            try
            {
                var url = base_url.AppendPathSegments("Getdistricts", stateID);
                var output = await url.GetJsonAsync<List<Districts>>();
                return output;
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                throw;
            }
        }

        internal async Task<List<States>> get_all_states()
        {
            try
            {
                var url = base_url.AppendPathSegments("Getstates");
                var output = await url.GetJsonAsync<List<States>>();
                return output;
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                throw;
            }
        }

        internal async Task<List<User_full_info>> get_full_details(int userID)
        {
            try
            {
                var url = base_url.AppendPathSegments("Getfulldetails", userID);
                var output = await url.GetJsonAsync<List<User_full_info>>();
                return output;
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                throw;
            }
        }

        internal async Task<List<User_dose_data>> get_all_doses(int userID)
        {
            try
            {
                var url = base_url.AppendPathSegments("Getalldoses", userID);
                var output = await url.GetJsonAsync<List<User_dose_data>>();
                return output;
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                throw;
            }
        }

        internal async Task<List<Hospital>> search_center(int district_index, int vaccine_index, int age_limit)
        {
            try
            {
                var url = base_url.AppendPathSegments("GetCenters", district_index, vaccine_index, age_limit);
                var output = await url.GetJsonAsync<List<Hospital>>();
                return output;
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                throw;
            }
        }

        internal async Task<string> insert_user_dose_data(User_dose_input user_dose)
        {
            try
            {
                var url = base_url.AppendPathSegments("PostDoseData");
                var output = await url.PostJsonAsync(user_dose);
                return "OK";
            }
            catch (Exception ex)
            {
                FileLogger logs = new FileLogger();
                logs.logError(ex);
                throw;
            }
        }
    }
}