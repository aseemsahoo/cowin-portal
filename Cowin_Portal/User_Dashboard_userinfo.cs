using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Cowin_Portal
{
    public partial class User_Dashboard_userinfo : Form
    {
        int user_id;

        List<User_full_info> curr_user = new List<User_full_info>();
        List<User_dose_data> curr_user_doses = new List<User_dose_data>();

        public User_Dashboard_userinfo(int userID)
        {
            InitializeComponent();
            this.user_id = userID;
            fill_form(user_id);
        }
        internal string display_text()
        {
            return "Your Information";
        }

        private async void fill_form(int user_id)
        {
            DataAccess db = new DataAccess();

            curr_user = await db.get_full_details(user_id);
            curr_user_doses = await db.get_all_doses(user_id);

            fill_user_data();
            fill_dose_data(0, dose1Label, vaccine1Label, hospital1Label, date1Label, dose1Pic, dose1Button);
            fill_dose_data(1, dose2Label, vaccine2Label, hospital2Label, date2Label, dose2Pic, dose2Button);
            fill_dose_data(2, dosePrecautionLabel, vaccinePrecautionLabel, hospitalPrecautionLabel, datePrecautionLabel, dosePrecautionPic, dosePrecautionButton);
        }
        private void fill_user_data()
        {
            if (curr_user[0].gender == "Male")
                user_pictureBox.Image = Properties.Resources.icons8_circled_user_male;
            else
                user_pictureBox.Image = Properties.Resources.icons8_circled_user_female;

            name_label.Text = curr_user[0].fullname;
            ref_id_label.Text = curr_user[0].ref_id;
            secret_code_label.Text = curr_user[0].ref_id.Substring(10);
            aadhaar_label.Text ="XXXX XXXX " + curr_user[0].aadhaar_no.Substring(8);
            year_label.Text = curr_user[0].birth_year.ToString();
        }

        private void fill_dose_data(int i, Label doseLabel, Label vaccineLabel, Label hospitalLabel, Label dateLabel, PictureBox dosePic, Guna2Button doseButton)
        {
            if (curr_user_doses.Count <= i || (i != 0 && (curr_user_doses[i - 1].dose_date - DateTime.Today).TotalDays >= 0))
            {
                // red
                dosePic.Image = Properties.Resources.icons8_red;
                vaccineLabel.Text = dateLabel.Text = "";
                doseButton.Text = "Schedule";

                hospitalLabel.Text = "Appointment not scheduled";
                
                if (i == 0)
                {
                    doseButton.Enabled = true;
                    return;
                }
                if (curr_user_doses.Count < i)
                    return;

                var diff_days = (curr_user_doses[i - 1].dose_date - DateTime.Today).TotalDays;
                if (curr_user_doses.Count == i && diff_days < 0)
                    doseButton.Enabled = true;
                else
                    doseButton.Enabled = false;
                return;
            }

            vaccineLabel.Text = curr_user_doses[i].vaccine_name;
            hospitalLabel.Text = curr_user_doses[i].hospital_name;
            dateLabel.Text = curr_user_doses[i].dose_date.ToString("yyyy-MM-dd");

            var days = (curr_user_doses[i].dose_date - DateTime.Today).TotalDays;
            if (days >= 0)
            {
                // yellow
                dosePic.Image = Properties.Resources.icons8_gold;
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
                dosePic.Image = Properties.Resources.icons8_green;
                doseButton.Text = "Schedule";
                doseButton.Enabled = false;

                doseLabel.ForeColor = Color.LimeGreen;
                vaccineLabel.ForeColor = Color.LimeGreen;
                hospitalLabel.ForeColor = Color.LimeGreen;
                dateLabel.ForeColor = Color.LimeGreen;
            }
        }

        private void open_appointment_form(int dose_type)
        {
            User_Dashboard_appointment user_appointment_form = new User_Dashboard_appointment(curr_user, curr_user_doses)
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

        private void hospital1Label_Click(object sender, EventArgs e)
        {

        }
    }
}