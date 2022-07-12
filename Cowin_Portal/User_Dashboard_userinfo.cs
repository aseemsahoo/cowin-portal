using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cowin_Portal
{
    public partial class User_Dashboard_userinfo : Form
    {
        int user_id;
        
        List<User_full_info> curr_user = new List<User_full_info>();
        List<User_dose_data> curr_user_doses = new List<User_dose_data>();
        
        public string display_text()
        {
            return "Your Information";
        }
        public User_Dashboard_userinfo(int userID)
        {
            InitializeComponent();
            user_id = userID;
            fill_form(user_id);
        }
        private void fill_dose_data(int i, Label doseLabel, Label vaccineLabel, Label hospitalLabel, Label dateLabel, Bunifu.UI.WinForms.BunifuPictureBox dosePic, Bunifu.UI.WinForms.BunifuButton.BunifuButton doseButton)
        {
            doseLabel.Text = "DOSE " + (i+1).ToString();
            if(i == 2)
                doseLabel.Text = "PRECAUTION DOSE";

            if (curr_user_doses.Count <= i)
            {
                // set photo red
                hospitalLabel.Text = "Appointment not scheduled";
                doseButton.Text = "Schedule";
                int a = curr_user_doses.Count;
                if (i == 0 || curr_user_doses.Count == i)
                    doseButton.Enabled = true;
                return;
            }

            // change button text to schedule
            doseButton.Text = "Download Certificate";
            vaccineLabel.Text = curr_user_doses[i].vaccine_name;
            hospitalLabel.Text = curr_user_doses[i].hospital_name;
            dateLabel.Text = curr_user_doses[i].dose_date.ToString("yyyy-MM-dd");

            doseLabel.ForeColor = Color.LimeGreen;
            vaccineLabel.ForeColor = Color.LimeGreen;
            hospitalLabel.ForeColor = Color.LimeGreen;
            dateLabel.ForeColor = Color.LimeGreen;

            // photo green
            doseButton.Text = "Download Certificate";
            doseButton.Enabled = false;
        }
        private void fill_user_data()
        {
            name_label.Text = curr_user[0].fullname;
            ref_id_label.Text = curr_user[0].ref_id;
            secret_code_label.Text = curr_user[0].ref_id.Substring(10);
            aadhaar_last_label.Text = curr_user[0].aadhaar_no.Substring(8);
            year_label.Text = curr_user[0].birth_year.ToString();
        }
        public void fill_form(int userID)
        {
            DataAccess db = new DataAccess();

            curr_user = db.get_full_details(userID);
            curr_user_doses = db.get_all_doses(userID);
            

            fill_user_data();
            fill_dose_data(0, dose1Label, vaccine1Label, hospital1Label, date1Label, dose1Pic, dose1Button);
            fill_dose_data(1, dose2Label, vaccine2Label, hospital2Label, date2Label, dose2Pic, dose2Button);
            fill_dose_data(2, dosePrecautionLabel, vaccinePrecautionLabel, hospitalPrecautionLabel, datePrecautionLabel, dosePrecautionPic, dosePrecautionButton);
        }

        private void open_appointment_form(int dose_type)
        {
            User_Dashboard_appointment user_appointment_form = new User_Dashboard_appointment(user_id, dose_type)
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
                p.Controls.Add(user_appointment_form);
                user_appointment_form.Show();
            }
        }
        private void dose1Button_Click(object sender, EventArgs e)
        {
            open_appointment_form(0);
        }

        private void dose2Button_Click(object sender, EventArgs e)
        {
            open_appointment_form(1);
        }

        private void dosePrecautionButton_Click(object sender, EventArgs e)
        {
            open_appointment_form(2);
        }
    }
}
