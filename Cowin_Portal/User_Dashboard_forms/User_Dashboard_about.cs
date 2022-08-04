using System.Diagnostics;
using System.Windows.Forms;

namespace Cowin_Portal.User_Dashboard_forms
{
    public partial class User_Dashboard_about : Form
    {
        public User_Dashboard_about()
        {
            InitializeComponent();
        }
        public string display_text()
        {
            return "About";
        }

        public void linkedin_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/aseem-sahoo/");
        }

        public void github_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/aseemsahoo");
        }
    }
}
