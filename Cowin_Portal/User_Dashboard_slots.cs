using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cowin_Portal
{
    public partial class User_Dashboard_slots : Form
    {

        List<Hospital> display = new List<Hospital>();
        List<States> state_list = new List<States>();
        List<Districts> district_list = new List<Districts>();

        public string display_text()
        {
            return "Search for a vaccination center";
        }

        public User_Dashboard_slots()
        {
            InitializeComponent();
            initialize_state_dropdown();
        }
        private void initialize_state_dropdown()
        {
            DataAccess db = new DataAccess();
            state_list = db.get_all_states();
            foreach (States s in state_list)
            {
                stateDropdown.Items.Add(s.name);
            }
        }
        private void stateDropdown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = stateDropdown.SelectedIndex;
            int state_id = state_list[index].id;

            DataAccess db = new DataAccess();
            district_list = db.get_districts(state_id);

            districtDropdown.Items.Clear();
            districtDropdown.SelectedIndex = -1;
            districtDropdown.Text = "";
            foreach (Districts d in district_list)
            {
                districtDropdown.Items.Add(d.name);
            }
        }

        private string get_groupbox_radiobuttion(BunifuGroupBox groupbox)
        {
            string res = "";
            foreach (RadioButton r in groupbox.Controls)
            {
                if (r.Checked)
                    res = r.Text;
            }
            return res;
        }
        private bool validate_controls()
        {
            errorProvider_slots.Clear();
            if (stateDropdown.SelectedIndex <= -1)
            {
                errorProvider_slots.SetError(this.stateDropdown, "Please select a state");
                return false;
            }
            if (districtDropdown.SelectedIndex <= -1)
            {
                errorProvider_slots.SetError(this.districtDropdown, "Please select a district");
                return false;
            }
            if (get_groupbox_radiobuttion(vaccine_groupbox) == "")
            {
                errorProvider_slots.SetError(this.vaccine_groupbox, "Please select a vaccine");
                return false;
            }
            return true;
        }

        private void get_vaccine_index(ref int vaccine_index)
        {
            string vaccine = get_groupbox_radiobuttion(vaccine_groupbox);

            if (vaccine == "Covishield")
                vaccine_index = 1;
            else
            if (vaccine == "Covaxin")
                vaccine_index = 2;
            else
                vaccine_index = 3;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (validate_controls() == false)
                return;
            int index = districtDropdown.SelectedIndex;
            int district_id = district_list[index].id;

            int vaccine_index = 0;
            int age_limit = Convert.ToInt32(get_groupbox_radiobuttion(age_groupbox));

            get_vaccine_index(ref vaccine_index);

            DataAccess db = new DataAccess();

            display = db.search_center(district_id, vaccine_index, age_limit);

            Centers_gridview.DataSource = display;
        }
    }
}
