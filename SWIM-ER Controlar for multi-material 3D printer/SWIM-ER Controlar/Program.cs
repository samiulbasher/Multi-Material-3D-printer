using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SWIM_ER_Controlar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ------------For dpi resolution problem solve------------
            if (Environment.OSVersion.Version.Major >= 2)
                SetProcessDPIAware();
            //---------------------------------------------------------

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // ------------For dpi resolution problem solve----------------
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        //-------------------------------------------------------------
    }
}
