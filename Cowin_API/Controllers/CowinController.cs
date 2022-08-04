using Cowin_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cowin_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CowinController : ControllerBase
    {
        private readonly API_DataAccess db;

        public CowinController()
        {
            db = new API_DataAccess();
        }

        [HttpGet]
        [Route("Getconnection")]
        public bool GetConnection()
        {
            return db.test_connection();
        }

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
        [Route("Getcenters/{district_index}/{vaccine_index}/{age_limit}")]
        public IEnumerable<Hospital> GetCenters(int district_index, int vaccine_index, int age_limit)
        {
            return db.search_center(district_index, vaccine_index, age_limit);
        }


        [HttpPost]
        [Route("[action]")]
        public string PostUser([FromBody] User_SignIn curr_user)
        {
            if (ModelState.IsValid)
                return db.insert_user(curr_user);
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
        public string PostDoseData([FromBody] User_dose_input curr_dose)
        {
            if (ModelState.IsValid)
                return db.insert_user_dose_data(curr_dose);
            return "";
        }
    }
}