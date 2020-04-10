using System;
using System.Windows.Forms;

namespace EventSYS
{
    internal static class Program
    {
       
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Taken from stackOverflow - After closing one form and opening thje other, the second closed and closed the App so i added this
            var main_form = new frmLogIn();
            main_form.Show();
            Application.Run();
        }

        //Taken from side menu tutorial 
        public static bool IsInDesignMode()
        {
            if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1)
            {
                return true;
            }
            return false;
        }
    }
}