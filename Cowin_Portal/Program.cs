using Cowin_Portal.Accessibility;
using System;
using System.Windows.Forms;

namespace Cowin_Portal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_UI());
        }
    }
}
