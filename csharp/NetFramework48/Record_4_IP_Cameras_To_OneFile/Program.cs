using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Record_4_IP_Cameras_To_OneFile
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
            Application.Run(new Form1());
        }
    }
}
