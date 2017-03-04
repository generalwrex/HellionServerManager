using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellionServerManager
{
    public static class Log
    {

        public static Boolean DebugMode = true;

        public static void Message(string line)
        {
            if (DebugMode)
                Console.WriteLine(line);
            else
                MessageBox.Show(line);

        }

    }
}
