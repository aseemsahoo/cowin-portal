using System;
using System.Windows.Forms;

namespace Cowin_Portal
{
    public partial class User_Dashboard : Form
    {
        private int user_id;
        public User_Dashboard(int userId)
        {
            InitializeComponent();
            user_id = userId;

            DataAccess db = new DataAccess();
            username_label.Text = db.get_username(user_id);

            user_dashboardButton_Click(new object(), new EventArgs());
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_display.Controls.Add(childForm);
            panel_display.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void user_dashboardButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int isRegister = db.get_register_status(user_id);
            if (isRegister == 1)
            {
                User_Dashboard_userinfo u_info = new User_Dashboard_userinfo(user_id);
                openChildForm(u_info);
                dashboard_label.Text = u_info.display_text();
            }
            else
            if(isRegister == 0)
            {
                User_Dashboard_RegisterDetails u_details = new User_Dashboard_RegisterDetails(user_id);
                openChildForm(u_details);
                dashboard_label.Text = u_details.display_text();
            }
            else
            {
                MessageBox.Show
                    ("Error Code: " + 
                    isRegister.ToString() +
                    " The application will stop running.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void user_centersButton_Click(object sender, EventArgs e)
        {
            User_Dashboard_slots u_register = new User_Dashboard_slots();
            openChildForm(u_register);
            dashboard_label.Text = u_register.display_text();
        }

        private void user_aboutButton_Click(object sender, EventArgs e)
        {
            User_Dashboard_about u_slots = new User_Dashboard_about();
            openChildForm(u_slots);
            dashboard_label.Text = u_slots.display_text();
        }
    }
}