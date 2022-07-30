using Cowin_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cowin_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CowinController : ControllerBase
    {
        private readonly DataAccess db;

        public CowinController()
        {
            db = new DataAccess();
        }

        [HttpGet]
        [Route("Getuser/{username}")]
        public IEnumerable<User_Login> GetUser(string username)
        {
            return db.get_login_data(username);
        }

        // introduce hyphens between words
        [HttpGet]
        [Route("Getregisterstatus/{id}")]
        public int GetRegisterStatus(int id)
        {
            return db.get_register_status(id);
        }

        [HttpGet]
        [Route("Getdistricts/{id}")]
        public IEnumerable<Districts> GetDistricts(int id)
        {
            return db.get_districts(id);
        }

        [HttpGet]
        [Route("Getstates")]
        public IEnumerable<States> GetStates()
        {
            return db.get_all_states();
        }

        [HttpGet]
        [Route("Getfulldetails/{id}")]
        public IEnumerable<User_full_info> GetFullDetails(int id)
        {
            return db.get_full_details(id);
        }

        [HttpGet]
        [Route("Getalldoses/{id}")]
        public IEnumerable<User_dose_data> GetDoses(int id)
        {
            return db.get_all_doses(id);
        }

        // https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/findByDistrict?district_id=245&date=12-10-2021
        [HttpGet]
        [Route("Getalldoses/{district_index}/{vaccine_index}/{age_limit}")]
        public IEnumerable<Hospital> GetCenters(int district_index, int vaccine_index, int age_limit)
        {
            return db.search_center(district_index, vaccine_index, age_limit);
        }


        [HttpPost]
        [Route("[action]")]
        public string PostUser(string phone_no, string u_name, string pw, string salt)
        {
            if (ModelState.IsValid)
                return db.insert_user(phone_no, u_name, pw, salt);
            return "";
        }

        [HttpPost]
        [Route("[action]")]
        public string PostRegisteredUser([FromBody] User_full_info user)
        {
            if (ModelState.IsValid)
                return db.insert_user_register(user);
            return "";
        }

        [HttpPost]
        [Route("[action]")]
        public string PostDoseData(int user_id, int hospital_id, string date, string time, int dose_type)
        {
            if (ModelState.IsValid)
                return db.insert_user_dose_data(user_id, hospital_id, date, time, dose_type);
            return "";
        }
    }
}