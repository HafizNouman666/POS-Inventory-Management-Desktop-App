using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
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

            //SplashScreen sp = new SplashScreen();
            //sp.Show();


            //Application.DoEvents();
            //System.Threading.Thread.Sleep(3000);
            //sp.Close();
            
            //Application.Run(new MDI());
            Application.Run(new SplashScreen());
        }
       

    }
}
