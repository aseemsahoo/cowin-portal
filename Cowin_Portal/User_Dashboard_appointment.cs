using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cowin_Portal
{
    public partial class User_Dashboard_appointment : Form
    {
        int user_id;
        int dose_type, vaccine_id, age_id;
        string dose1_date;

        List<Hospital> display = new List<Hospital>();
        List<States> state_list = new List<States>();
        List<Districts> district_list = new List<Districts>();
        
        public string display_text()
        {
            return "Schedule vaccination appointment";
        }

        public User_Dashboard_appointment(int userId, int doseType)
        {
            InitializeComponent();
            initialize_state_dropdown();
            
            user_id = userId;
            dose_type = doseType;

            if(dose_type == 0)
            {
                age_groupbox.Enabled = true;
                vaccine_groupbox.Enabled = true;
            }
            else
            {
                load_age_vaccine_refid();
                age_groupbox.Enabled = false;
                vaccine_groupbox.Enabled = false;
            }
            vaccineDatePicker.MinDate = DateTime.Today;
            vaccineDatePicker.MaxDate = DateTime.Today.AddDays(10);
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

        private void load_age_vaccine_refid()
        {
            DataAccess db = new DataAccess();
            age_id = db.get_dose1_age(user_id)[0];
            vaccine_id = db.get_dose1_vaccine(user_id)[0];
            dose1_date = db.get_dose1_date(user_id)[0].ToString("yyyy-MM-dd");
        }

        private void stateDropdown_SelectedIndexChanged(object sender, EventArgs e)
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
            errorProvider_ap.Clear();
            if(stateDropdown.SelectedIndex <= -1)
            {
                errorProvider_ap.SetError(this.stateDropdown, "Please select a state");
                return false;
            }
            if (districtDropdown.SelectedIndex <= -1)
            {
                errorProvider_ap.SetError(this.districtDropdown, "Please select a district");
                return false;
            }
            if(dose_type == 0)
            {
                if (get_groupbox_radiobuttion(age_groupbox) == "")
                {
                    errorProvider_ap.SetError(this.age_groupbox, "Please select appropriate age");
                    return false;
                }
                if (get_groupbox_radiobuttion(vaccine_groupbox) == "")
                {
                    errorProvider_ap.SetError(this.vaccine_groupbox, "Please select a vaccine");
                    return false;
                }
            }
            return true;
        }
        private void get_vaccine_index(ref int vaccine_index)
        {
            if(dose_type != 0)
            {
                vaccine_index = vaccine_id;
                return;
            }
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
            if(validate_controls() == false)
                return ;
            int index = districtDropdown.SelectedIndex;
            int district_id = district_list[index].id;

            int vaccine_index = 0;
            int age_limit = Convert.ToInt32(get_groupbox_radiobuttion(age_groupbox));

            get_vaccine_index(ref vaccine_index);

            DataAccess db = new DataAccess();
            
            // check if age works
            display = db.search_center(district_id, vaccine_index, age_limit);

            Centers_gridview.DataSource = display;
        }

        private void slot_select_nextButton_Click(object sender, EventArgs e)
        {
            if (validate_controls() == false)
                return;
            if(Centers_gridview.SelectedRows.Count == 0)
                return;
            display_on_second_tab();
            appointment_stepsPages.SetPage(1);
        }

        //---------------------------------------------------------------------------------
        // End of first tab
        //---------------------------------------------------------------------------------

        private string vaccine_from_id()
        {
            string vaccine_name;
            if (vaccine_id == 1)
                vaccine_name = "Covishield";
            else
            if (vaccine_id == 2)
                vaccine_name = "Covaxin";
            else
                vaccine_name = "Sputnik-V";
            return vaccine_name;
        }

        private void display_on_second_tab()
        {
            DataAccess db = new DataAccess();
            string ref_id = db.get_full_details(user_id)[0].ref_id;
            
            int index = Centers_gridview.CurrentCell.RowIndex;
            int hospital_id = display[index].id;

            string vaccine;
            if (dose_type == 0)
                vaccine = get_groupbox_radiobuttion(vaccine_groupbox);
            else
                vaccine = vaccine_from_id();

            hospital_nameLabel.Text = display[index].name;
            hospital_addressLabel.Text = display[index].address;
            vaccineLabel.Text = vaccine;
            ref_idLabel.Text = ref_id;
        }

        private void appointment_stepsPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(appointment_stepsPages.SelectedIndex)
            {
                case 1:
                    c1.Checked = c1.Enabled = true;
                    l1.ForeColor = Color.Navy;
                    break;
                case 2:
                    c2.Checked = c2.Enabled = true;
                    l2.ForeColor = Color.Navy;
                    break;
            }
        }
        private bool validate_date_time()
        {
            if(dose_type != 0)
            {
                DateTime chosen_date = vaccineDatePicker.Value;
                DateTime dose_date = DateTime.Parse(dose1_date);

                var days = (chosen_date - dose_date).TotalDays;

                if(days <= 180)
                {
                    MessageBox.Show
                        ("Gap between two doses must be at least 3 months. Please try later. " +
                        "You will be re-directed back to the user dashboard.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    finish_button_Click(new Object(), new EventArgs());
                    return false;
                }
            }
            errorProvider_ap.Clear();
            if (get_groupbox_radiobuttion(time_groupbox) == "")
            {
                errorProvider_ap.SetError(this.time_groupbox, "wrong 2");
                return false;
            }
            return true;
        }

        private void time_select_backButton_Click(object sender, EventArgs e)
        {
            appointment_stepsPages.SetPage(0);
        }

        private void time_select_submitButton_Click(object sender, EventArgs e)
        {
            if (validate_date_time() == false)
                return;
            string date = vaccineDatePicker.Value.ToString("yyyy-MM-dd");
            string time = get_groupbox_radiobuttion(time_groupbox);

            int index = Centers_gridview.CurrentCell.RowIndex;
            int hospital_id = display[index].id;

            DataAccess db = new DataAccess();
            string res = db.insert_user_dose_data(user_id, hospital_id, date, time, dose_type);

            if (res != "OK")
                return;

            appointment_stepsPages.SetPage(2);
            c3.Checked = c3.Enabled = true;
            l3.ForeColor = Color.Navy;
        }

        private void finish_button_Click(object sender, EventArgs e)
        {
            User_Dashboard_userinfo user_info_form = new User_Dashboard_userinfo(user_id)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
            };
            
            Form frm = this.Parent.FindForm();
            
            Control match = frm.Controls.Find("panel_display", true).FirstOrDefault();
            if (match != null && match is Panel)
            {
                Panel p = (Panel)match;
                p.Controls.Clear();
                p.Controls.Add(user_info_form);
                user_info_form.Show();
            }

            // TEST THIS
            Control match_label = frm.Controls.Find("dashboard_label", true).FirstOrDefault();
            if (match_label != null && match_label is Label)
            {
                Label l = (Label)match;
                l.Text = user_info_form.display_text();
            }
        }
    }
}
