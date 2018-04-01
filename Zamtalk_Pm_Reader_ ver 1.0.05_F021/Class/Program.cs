using System;
using System.Windows.Forms;
using Zamtalk_Pm_Reader__ver_1._0._05_F021;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
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
          Application.Run(new FRM_Main());
          //Application.Run(new Form1());
        
        }
    }
}
