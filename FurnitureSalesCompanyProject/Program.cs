using FurnitureSalesCompanyProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureSalesCompanyProject
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // AddStartingDate addStartingDate = new AddStartingDate();
            // addStartingDate.Add();
            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
            while (mainForm.DialogResult == DialogResult.Retry)
            {
                mainForm = new MainForm();
                Application.Run(mainForm);
            }

        }
    }
}
