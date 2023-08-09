using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace TicTacToeConsole
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.Diagnostics.Process.GetProcessesByName("過三關").Count() == 0)
            {
                if (System.IO.File.Exists("過三關.exe") == true) { System.Diagnostics.Process.Start("過三關.exe"); }
                Environment.Exit(0);
            }
            else
            {
                for (int i = 0; i < System.Diagnostics.Process.GetProcessesByName("過三關").Count(); ++i)
                {
                    if (new Regex("過三關.exe$").Replace(System.Diagnostics.Process.GetProcessesByName("過三關")[i].MainModule.FileName, "") !=
                        new Regex("TicTacToeConsole.exe$").Replace(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName, "")) { Environment.Exit(0); }
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
