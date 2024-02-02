using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FaceRec
{
    static class Program
    {
        /// <summary>
        /// Primary entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}
//