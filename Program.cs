using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        //    Application.Run(new ManagementForm());
            Login formLogin = new Login();
            Application.Run(formLogin);

            if (AppData.isLoginAdmin == true)
            {
                Application.Run(new ManagementForm());
            }

            if (AppData.isLoginUser == true)
            {
                Application.Run(new Search());
            }
        }
    }
}
