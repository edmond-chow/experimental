using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 過三關
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG
            DataRemove();
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
#if DEBUG
            DataRemove();
#endif
        }
#if DEBUG
        private static void DataRemove()
        {
            if (System.IO.File.Exists(".TicTacToe") == true) { System.IO.File.Delete(".TicTacToe"); }
            if (System.IO.File.Exists("console.log") == true) { System.IO.File.Delete("console.log"); }
            if (System.IO.File.Exists("debug.log") == true) { System.IO.File.Delete("debug.log"); }
            if (System.IO.File.Exists("bugs.log") == true) { System.IO.File.Delete("bugs.log"); }
        }
#endif
    }
}
