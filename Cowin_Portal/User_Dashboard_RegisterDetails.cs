using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Cowin_Portal
{
    public partial class User_Dashboard_RegisterDetails : Form
    {
        int user_id;
        public User_Dashboard_RegisterDetails(int userID)
        {
            user_id = userID;
            InitializeComponent();
        }

        internal string display_text()
        {
            return "Register for vaccination";
        }
        private string get_groupbox_radiobuttion(Panel groupbox)
        {
            string res = "";
            foreach (RadioButton r in groupbox.Controls)
            {
                if (r.Checked)
                    res = r.Text;
            }
            return res;
        }
        private bool validate_user_register()
        {
            errorProvider_register.Clear();

            RegexValidation rgx = new RegexValidation();
            if (rgx.isValid_fullname(NameInsText.Text) == false)
            {
                errorProvider_register.SetError(this.NameInsText, "Enter valid name");
                return false;
            }
            string res = get_groupbox_radiobuttion(panel1);

            bool isChecked = false;
            if (res != "")
                isChecked = true;

            if (isChecked == false)
            {
                errorProvider_register.SetError(this.genderLabel, "Please select a gender");
                return false;
            }
            if(rgx.isValid_birthyear(YearInsText.Text))
            {
                errorProvider_register.SetError(this.YearInsText, "Birth year must be between 1945 and 2013");
                return false;
            }
            if (rgx.isValid_aadhaar(AadhaarInsText.Text))
            {
                errorProvider_register.SetError(this.AadhaarInsText, "Please enter a valid 14-digit aadhaar");
                return false;
            }
            return true;
        }
        private void clear_textbox()
        {
            NameInsText.Text = "";
            YearInsText.Text = "";
            AadhaarInsText.Text = "";
        }
        private string get_radiobutton_string()
        {
            string gender = "";
            foreach (RadioButton r in panel1.Controls)
            {
                if (r.Checked)
                    gender = r.Text;
            }
            return gender;
        }

        private string generate_random_refID()
        {
            Random rnd = new Random();

            int n1 = rnd.Next(60000, 98000);
            int n2 = rnd.Next(10000, 99999);
            int n3 = rnd.Next(0001, 9999);

            string ref_id = n1.ToString() + n2.ToString() + n3.ToString();
            return ref_id;
        }
        private async void user_registerButton_Click(object sender, EventArgs e)
        {
            if (validate_user_register() == false)
                return;
            DataAccess db = new DataAccess();
            string res = await db.insert_user_register(user_id, NameInsText.Text, get_radiobutton_string(), int.Parse(YearInsText.Text), AadhaarInsText.Text, generate_random_refID());
            if (res == "OK")
            {
                MessageBox.Show
                    ("Registered !",
                    "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_textbox();
                open_userinfo_form();
            }
            else
            {
                MessageBox.Show
                    ("Exception catch here - details  : " + res,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void open_userinfo_form()
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