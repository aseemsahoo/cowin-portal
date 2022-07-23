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

        User_full_info curr_user = new User_full_info();

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

            DataAccess db = new DataAccess();
            curr_user = db.get_full_details(user_id)[0];

            if (dose_type == 0)
            {
                set_age_radiobutton();
                vaccine_groupbox.Enabled = true;
            }
            else
            {
                load_age_vaccine_refid();
                vaccine_groupbox.Enabled = false;
            }
            vaccineDatePicker.MinDate = DateTime.Today;
            vaccineDatePicker.MaxDate = DateTime.Today.AddDays(10);
        }

        private void set_age_radiobutton()
        {
            int birth_year = curr_user.birth_year;
            int age = DateTime.Now.Year - birth_year;
            if( age < 18)
            {
                MessageBox.Show
                    ("You must be minimum 18 years of age. " +
                    "You will be re-directed back to the user dashboard.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                finish_button_Click(new Object(), new EventArgs());
            }
            else
            if (age >= 18 && age < 45)
            {
                age18_radiobutton.Checked = true;
                age_groupbox.Enabled = false;
            }
            else
            {
                age45_radiobutton.Checked = true;
                age_groupbox.Enabled = true;
            }
        }

        private void load_age_vaccine_refid()
        {
            DataAccess db = new DataAccess();

            age_id = db.get_dose1_age(user_id)[0];
            vaccine_id = db.get_dose1_vaccine(user_id)[0];
            dose1_date = db.get_dose1_date(user_id)[0].ToString("yyyy-MM-dd");

            set_radiobutton(age_groupbox, age_id + "+");
            set_radiobutton(vaccine_groupbox, vaccine_from_id());
        }

        private void initialize_state_dropdown()
        {
            DataAccess db = new DataAccess();
            state_list = db.get_all_states();
            foreach (States s in state_list)
            {
                state_comboBox.Items.Add(s.name);
            }
        }

        private void set_radiobutton(GroupBox groupbox, string s)
        {
            foreach (RadioButton r in groupbox.Controls)
            {
                if (r.Text == s)
                    r.Checked = true;
            }
        }

        private void state_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = state_comboBox.SelectedIndex;
            int state_id = state_list[index].id;

            DataAccess db = new DataAccess();
            district_list = db.get_districts(state_id);

            district_comboBox.Items.Clear();
            district_comboBox.SelectedIndex = -1;
            district_comboBox.Text = "";
            foreach (Districts d in district_list)
            {
                district_comboBox.Items.Add(d.name);
            }
        }

        private string get_groupbox_radiobuttion(GroupBox groupbox)
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
            if (state_comboBox.SelectedIndex <= -1)
            {
                errorProvider_ap.SetError(this.state_comboBox, "Please select a state");
                return false;
            }
            if (district_comboBox.SelectedIndex <= -1)
            {
                errorProvider_ap.SetError(this.district_comboBox, "Please select a district");
                return false;
            }
            if (dose_type == 0)
            {
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
            if (dose_type != 0)
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

            if (validate_controls() == false)
                return;
            int index = district_comboBox.SelectedIndex;
            int district_id = district_list[index].id;

            int vaccine_index = 0, age_limit;
            if (dose_type != 0)
            {
                age_limit = age_id;
                vaccine_index = vaccine_id;
            }
            else
            {
                age_limit = Convert.ToInt32(get_groupbox_radiobuttion(age_groupbox).Substring(0, 2));
                get_vaccine_index(ref vaccine_index);
            }

            DataAccess db = new DataAccess();
            display = db.search_center(district_id, vaccine_index, age_limit);

            Centers_gridview.DataSource = display;
            Centers_gridview.CurrentCell = null;


            Centers_gridview.Columns[0].Width = (int)(Centers_gridview.Width * 0.45);
            Centers_gridview.Columns[1].Width = (int)(Centers_gridview.Width * 0.4);
            Centers_gridview.Columns[2].Width = (int)(Centers_gridview.Width * 0.15);
        }
        private void slot_select_nextButton_Click(object sender, EventArgs e)
        {
            if (validate_controls() == false)
                return;
            if (Centers_gridview.CurrentCell == null)
            {
                errorProvider_ap.SetError(this.slot_search_label, "Please select a center");
                return;
            }
            display_on_second_tab();
            appointment_stepsPages.SelectedIndex = 1;
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
            fullname_label.Text = curr_user.fullname;
            ref_idLabel.Text = curr_user.ref_id;
        }

        private void appointment_stepsPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (appointment_stepsPages.SelectedIndex)
            {
                case 1:
                    ck2.Checked = true;
                    l2.ForeColor = Color.Navy;
                    break;
                case 2:
                    ck3.Checked = true;
                    l3.ForeColor = Color.Navy;
                    break;
            }
        }

        private bool validate_date_time()
        {
            if (dose_type != 0)
            {
                DateTime chosen_date = vaccineDatePicker.Value;
                DateTime dose_date = DateTime.Parse(dose1_date);

                var days = (chosen_date - dose_date).TotalDays;

                if (days <= 180)
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
            appointment_stepsPages.SelectedIndex = 0;
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

            appointment_stepsPages.SelectedIndex = 2;
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

            Control match_label = frm.Controls.Find("dashboard_label", true).FirstOrDefault();
            if (match_label != null && match_label is Label)
            {
                Label l = (Label)match_label;
                l.Text = user_info_form.display_text();
            }
        }
    }
}