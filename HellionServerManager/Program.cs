using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HellionServerManager
{
    static class Program
    {
        public static Thread UIThread;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            UIThread = new Thread(() => {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            });
            UIThread.SetApartmentState(ApartmentState.STA);
            UIThread.Start();

            Log.DebugMode = true;

        }
    }
}
