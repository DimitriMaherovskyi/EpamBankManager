using BankManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositories
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
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            LoginForm frmLogin = new LoginForm();
            if(frmLogin.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Application.Run(new MainForm());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Error", "BankManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
