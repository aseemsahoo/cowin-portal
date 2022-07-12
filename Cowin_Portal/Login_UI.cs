using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Cowin_Portal
{
    public partial class Login_UI : Form
    {
        public Login_UI()
        {
            InitializeComponent();
            cowin_intro_page.SetPage(2);
            /*
            cowin_page_dock.SubscribeControlToDragEvents(cowin_PictureBox1);
            cowin_page_dock.SubscribeControlToDragEvents(cowin_page_GradientPanel1);
            cowin_page_dock.SubscribeControlToDragEvents(login_page);
            cowin_page_dock.SubscribeControlToDragEvents(signup_page);
            */
            DataAccess db = new DataAccess();
            bool res = db.get_register_status(1);
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
        private void login_select_button_Click(object sender, EventArgs e)
        {
            cowin_intro_page.SetPage(1);
        }
        private void signup_select_Button_Click(object sender, EventArgs e)
        {
            cowin_intro_page.SetPage(0);
        }
        private void clear_textbox()
        {
            PhNumberInsTxt.Text = "";
            usernameInsTxt.Text = "";
            passwordInsTxt.Text = "";
        }
        private bool validate_signup()
        {
            errorProvider_signup.Clear();
            RegexValidation regex_signup = new RegexValidation();
            if (Regex.IsMatch(PhNumberInsTxt.Text, regex_signup.PHONENUMBER_REGEX) == false)
            {
                errorProvider_signup.SetError(this.PhNumberInsTxt, "Please enter valid Phone Number");
                return false;
            }
            if (Regex.IsMatch(usernameInsTxt.Text, regex_signup.USERNAME_REGEX) == false)
            {
                errorProvider_signup.SetError(this.usernameInsTxt, "Username invalid");
                return false;
            }
            // note we use == true here;
            if (Regex.IsMatch(passwordInsTxt.Text, regex_signup.PASSWORD_REGEX) == true)
            {
                errorProvider_signup.SetError(this.passwordInsTxt, "Passsword must be within 9-14 characters and contain a symbol");
                return false;
            }
            return true;
        }
        private void signup_final_button_Click(object sender, EventArgs e)
        {
            if (validate_signup() == false)
                return;
            DataAccess db = new DataAccess();
            string res = db.insert_user(PhNumberInsTxt.Text, usernameInsTxt.Text, passwordInsTxt.Text);
            if(res != "OK")
            {
                MessageBox.Show
                    ("Exception catch here - details  : " + res, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            else
            {
                MessageBox.Show
                    ("Your account has been created",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clear_textbox();
            cowin_intro_page.SetPage(1);
        }

        private void login_final_button_Click(object sender, EventArgs e)
        {
            errorProvider_signup.Clear();
            DataAccess db = new DataAccess();
            int res = db.get_login_status(login_username.Text, login_password.Text);
            if (res > 0)
            {
                User_Dashboard User_d = new User_Dashboard(res);
                User_d.Show();
                this.Hide();
            }
            else
            if(res == -1)
                errorProvider_signup.SetError(this.login_password, "Wrong Password");
            else
                errorProvider_signup.SetError(this.login_username, "Username doesn't exist");
        }
        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
