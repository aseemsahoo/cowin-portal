using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Cowin_Portal
{
    public partial class Login_UI : Form
    {
        public Login_UI()
        {
            InitializeComponent();
            cowin_tab.SelectedIndex = 0;
            set_status_text();
        }

        private void set_status_text()
        {
            DataAccess db = new DataAccess();

            bool res = db.test_connection();
            if (res == true)
            {
                status_label.Text = "Connected to Database";
                status_label.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                status_label.Text = "Couldn't connect to Database";
                status_label.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void clear_textbox()
        {
            PhNumberInsTxt.Text = "";
            usernameInsTxt.Text = "";
            passwordInsTxt.Text = "";
        }
        private bool validate_signup()
        {
            errorProvider_cowin.Clear();
            RegexValidation rgx = new RegexValidation();
            if (rgx.isValid_phonenumber(PhNumberInsTxt.Text) == false)
            {
                errorProvider_cowin.SetError(this.PhNumberInsTxt, "Please enter valid Phone Number");
                return false;
            }
            if (rgx.isValid_username(usernameInsTxt.Text) == false)
            {
                errorProvider_cowin.SetError(this.usernameInsTxt, "Username invalid");
                return false;
            }
            if (rgx.isValid_password(passwordInsTxt.Text) == false)
            {
                errorProvider_cowin.SetError(this.passwordInsTxt, "Passsword must be within 9-14 characters and contain a symbol");
                return false;
            }
            return true;
        }
        private bool validate_login()
        {
            errorProvider_cowin.Clear();
            if (login_username.Text == "")
            {
                errorProvider_cowin.SetError(this.login_username, "Username invalid");
                return false;
            }
            if (login_password.Text == "")
            {
                errorProvider_cowin.SetError(this.login_password, "Passsword must be within 9-14 characters and contain a symbol");
                return false;
            }
            return true;
        }

        private void signup_final_button_Click(object sender, EventArgs e)
        {
            if (validate_signup() == false)
                return;
            DataAccess db = new DataAccess();
            SaltHash sh = new SaltHash();

            string salt = sh.GetSalt();
            string hashed_password = sh.Hash(passwordInsTxt.Text, salt);

            string res = db.insert_user(PhNumberInsTxt.Text, usernameInsTxt.Text, hashed_password, salt);
            if (res == "OK")
            {
                MessageBox.Show
                    ("Your account has been created",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_textbox();
                cowin_tab.SelectedIndex = 2;
            }
            else
            {
                MessageBox.Show
                    ("Exception catch here - details  : " + res,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_final_button_Click(object sender, EventArgs e)
        {
            if (validate_login() == false)
                return;

            DataAccess db = new DataAccess();
            SaltHash sh = new SaltHash();

            List<User_Login> curr_user = db.get_login_data(login_username.Text);

            if (curr_user.Count == 0)
            {
                errorProvider_cowin.SetError(this.login_username, "Username doesn't exist");
            }
            else
            if(sh.Verify(login_password.Text, curr_user[0].password) == false)
            {
                errorProvider_cowin.SetError(this.login_password, "Wrong Password");
            }
            else
            {
                User_Dashboard User_d = new User_Dashboard(curr_user[0].id);
                this.Hide();
                if(User_d.IsDisposed == false)
                    User_d.ShowDialog();
                this.Close();
            }
        }

        private void signup_select_Button_Click(object sender, EventArgs e)
        {
            cowin_tab.SelectedIndex = 1;
        }
        private void login_select_button_Click(object sender, EventArgs e)
        {
            cowin_tab.SelectedIndex = 2;
        }
        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}