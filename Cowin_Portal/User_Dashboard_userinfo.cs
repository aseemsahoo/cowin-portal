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
            doseLabel.Text = "DOSE " + (i + 1).ToString();
            if (i == 2)
                doseLabel.Text = "PRECAUTION DOSE";

            if (curr_user_doses.Count <= i || (i != 0 && (curr_user_doses[i-1].dose_date - DateTime.Today).TotalDays >= 0))
            {
                // red
                dosePic.Image = Cowin_Portal.Properties.Resources.icons8_red;
                hospitalLabel.Text = "Appointment not scheduled";
                doseButton.Text = "Schedule";
                if (curr_user_doses.Count < i)
                    return;
                var diff_days = (curr_user_doses[i - 1].dose_date - DateTime.Today).TotalDays;
                if (i == 0 || (curr_user_doses.Count == i && diff_days < 0))
                    doseButton.Enabled = true;
                else
                    doseButton.Enabled = false;
                return;
            }

            vaccineLabel.Text = curr_user_doses[i].vaccine_name;
            hospitalLabel.Text = curr_user_doses[i].hospital_name;
            dateLabel.Text = curr_user_doses[i].dose_date.ToString("yyyy-MM-dd");

            var days = (curr_user_doses[i].dose_date - DateTime.Today).TotalDays;
            if (days > 0)
            {
                // yellow
                dosePic.Image = Cowin_Portal.Properties.Resources.icons8_gold;
                doseButton.Text = "Reschedule";
                doseButton.Enabled = true;

                doseLabel.ForeColor = Color.Goldenrod;
                vaccineLabel.ForeColor = Color.Goldenrod;
                hospitalLabel.ForeColor = Color.Goldenrod;
                dateLabel.ForeColor = Color.Goldenrod;
            }
            else
            {
                // green
                dosePic.Image = Cowin_Portal.Properties.Resources.icons8_green;
                doseButton.Text = "Download Certificate";
                doseButton.Enabled = false;

                doseLabel.ForeColor = Color.LimeGreen;
                vaccineLabel.ForeColor = Color.LimeGreen;
                hospitalLabel.ForeColor = Color.LimeGreen;
                dateLabel.ForeColor = Color.LimeGreen;
            }
        }
        private void fill_user_data()
        {
            if (curr_user[0].gender == "Male")
                user_pictureBox.Image = Cowin_Portal.Properties.Resources.icons8_circled_user_male;
            else
                user_pictureBox.Image = Cowin_Portal.Properties.Resources.icons8_circled_user_female;
            
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
            fill_dose_data(0, dose1Label, vaccine1Label, hospital1Label, date1Label, dose1_picbox, dose1Button);
            fill_dose_data(1, dose2Label, vaccine2Label, hospital2Label, date2Label, dose2_picbox, dose2Button);
            fill_dose_data(2, dosePrecautionLabel, vaccinePrecautionLabel, hospitalPrecautionLabel, datePrecautionLabel, dosePrecaution_picbox, dosePrecautionButton);
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

            Control match_label = frm.Controls.Find("dashboard_label", true).FirstOrDefault();
            if (match_label != null && match_label is Label)
            {
                Label l = (Label)match_label;
                l.Text = user_appointment_form.display_text();
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
