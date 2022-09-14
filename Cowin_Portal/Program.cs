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
            /*
            FlurlHttp.ConfigureClient
                ("https://localhost:5001/api/Cowin/", 
                cli => cli.Settings.HttpClientFactory = new UntrustedCertClientFactory());
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_UI());
        }
    }
}
