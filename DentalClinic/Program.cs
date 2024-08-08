using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using DentalClinic.Login;
using DentalClinic.Screen.Payments;

namespace DentalClinic
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            frmLoginView loginFrom = new frmLoginView();

            Application.Run(loginFrom);
        }
    }
}
