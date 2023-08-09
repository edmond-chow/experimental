using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace TicTacToeConsole
{
    public partial class MainForm : Form
    {
        private string LastExceptionMessage = "";
        private bool Showing = true;
        private int WonCount = 0;
        private int TiedCount = 0;
        private int LostCount = 0;
        private string BaseString = "";
        private string OutputString = "";
        private bool FirstOutput = true;
        private bool FirstBugs = true;
        private bool DebugMode = false;
        public MainForm() { InitializeComponent(); }
        private void Form_Load(object sender, EventArgs e)
        {
            this.Text = Basic.Title;
            foreach (string arg in Environment.GetCommandLineArgs())
            {
                if (arg == "Debug") { DebugMode = true; }
            }
            if (DebugMode == false) { dataName = "console"; }
            else { dataName = "debug"; }
            Win32.AllocConsole();
            Console.Clear();
            if (DebugMode == false) { Console.Title = "TicTacToe Testing Console"; }
            else
            {
                Console.Title = "TicTacToe DebugMode Testing Console";
                Basic.ClickBase(TicTacToeLibrary.Base.TicTacToeBaseControl.D);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            BaseString = "[Startup] on " + string.Format("{0:dd/MM/yyyy}", DateTime.Now) + " at " + string.Format("{0:HH:mm:ss}", DateTime.Now) + "\r\n";
            if (System.IO.File.Exists(dataName + ".log") == true)
            {
                try
                {
                    foreach (string Line in System.IO.File.ReadLines(dataName + ".log"))
                    {
                        if (Line.Contains("Won") == true) { WonCount = WonCount + 1; }
                        if (Line.Contains("Tied") == true) { TiedCount = TiedCount + 1; }
                        if (Line.Contains("Lost") == true) { LostCount = LostCount + 1; }
                    }
                }
                catch (System.IO.IOException ex)
                {
                    LastExceptionMessage = ex.Message; 
                    Environment.Exit(0);
                }
            }
            Basic.AutoDubegging = true;
            Basic.Lock = true;
            int Rand = TicTacToeLibrary.Base.RndRemove(9, 1, Basic.GetRemoves());
            Basic.ClickBase((TicTacToeLibrary.Base.TicTacToeBaseControl)Rand);
        }
        private void Basic_Click(object sender, EventArgs e) { this.Text = Basic.Title; }
        private void Basic_TicTacToeKeyDown(object sender, KeyEventArgs e) { this.Text = Basic.Title; }
        private void Basic_TicTacToeNewRound(object sender, TicTacToeLibrary.Base.TicTacToeRoundEventArgs e)
        {
            if (Basic.Round == 1)
            {
                if (Basic.Mode == TicTacToeLibrary.Base.TicTacToeMode.GeneralAttack || Basic.Mode == TicTacToeLibrary.Base.TicTacToeMode.DebugAttack)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("[Attacker]");
                    OutputString = OutputString + "[Attacker]";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("[Defender]");
                    OutputString = OutputString + "[Defender]";
                }
                Console.Write(" ");
                OutputString = OutputString + " ";
            }
            if (Basic.Round <= 9)
            {
                if (DebugMode == false)
                {
                    if (e.AIDetails == "(NonAI)")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(((int)e.HasClicked).ToString());
                        OutputString = OutputString + ((int)e.HasClicked).ToString();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(((int)e.HasClicked).ToString() + "(" + e.AIDetails + ")");
                        OutputString = OutputString + ((int)e.HasClicked).ToString() + "(" + e.AIDetails + ")";
                    }
                }
                else
                {
                    if (e.AIDetails == "([Debug]Player)")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(((int)e.HasClicked).ToString() + "(Player)");
                        OutputString = OutputString + ((int)e.HasClicked).ToString() + "(Player)";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(((int)e.HasClicked).ToString() + "(AI)");
                        OutputString = OutputString + ((int)e.HasClicked).ToString() + "(AI)";
                    }
                }
                Console.Write(" > ");
                OutputString = OutputString + " > ";
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
        }
        private void TicTacToeTestingTimer_Tick(object sender, EventArgs e)
        {
            Basic.ClickBase(TicTacToeLibrary.Base.TicTacToeBaseControl.ButtonChange);
            int Rand = TicTacToeLibrary.Base.RndRemove(9, 1, Basic.GetRemoves());
            Basic.ClickBase((TicTacToeLibrary.Base.TicTacToeBaseControl)Rand);
        }
        private void Basic_TicTacToeHasResult(object sender, TicTacToeLibrary.Base.TicTacToeResultEventArgs e)
        {
            if (e.Result == TicTacToeLibrary.Base.TicTacToeResult.Won)
            {
                WonCount = WonCount + 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Win");
                OutputString = OutputString + "Win";
            }
            else if (e.Result == TicTacToeLibrary.Base.TicTacToeResult.Tied)
            {
                TiedCount = TiedCount + 1;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Tied");
                OutputString = OutputString + "Tied";
            }
            else if (e.Result == TicTacToeLibrary.Base.TicTacToeResult.Lost)
            {
                LostCount = LostCount + 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Lost");
                OutputString = OutputString + "Lost";
            }
            if (e.Result == TicTacToeLibrary.Base.TicTacToeResult.Won) { BugsNext(); }
            BasicNext();
        }
        private System.IO.StreamWriter bugs;
        private System.IO.StreamWriter HasBugs;
        private void BugsNext()
        {
            if (DebugMode == false)
            {
                if (FirstBugs == true)
                {
                    try
                    {
                        bugs = new System.IO.StreamWriter("bugs.log", true);
                        HasBugs = new System.IO.StreamWriter(".bugs", true);
                        System.IO.File.SetAttributes(".bugs", System.IO.FileAttributes.Hidden);
                        FirstBugs = false;
                        bugs.WriteLine(BaseString + OutputString);
                    }
                    catch (System.IO.IOException ex)
                    {
                        LastExceptionMessage = ex.Message;
                        System.Environment.Exit(0);
                    }
                }
                else
                {
                    bugs.WriteLine(OutputString);
                    bugs.Close();
                    bugs = new System.IO.StreamWriter("bugs.log", true);
                }
            }
        }
        private string dataName = "";
        private System.IO.StreamWriter data;
        private System.IO.StreamWriter HasData;
        private void BasicNext()
        {
            if (DebugMode == false)
            {
                Console.Title = "TicTacToe Testing Console (Game: " + (WonCount + TiedCount + LostCount).ToString() + ")[Won: " + ((double)WonCount / (WonCount + TiedCount + LostCount) * 100).ToString() + "%, Tied: " + ((double)TiedCount / (WonCount + TiedCount + LostCount) * 100).ToString() + "%, Lost: " + ((double)LostCount / (WonCount + TiedCount + LostCount) * 100).ToString() + "%]";
                dataName = "console";
            }
            else
            {
                Console.Title = "TicTacToe DebugMode Testing Console (Game: " + (WonCount + TiedCount + LostCount).ToString() + ")[Won: " + ((double)WonCount / (WonCount + TiedCount + LostCount) * 100).ToString() + "%, Tied: " + ((double)TiedCount / (WonCount + TiedCount + LostCount) * 100).ToString() + "%, Lost: " + ((double)LostCount / (WonCount + TiedCount + LostCount) * 100).ToString() + "%]";
                dataName = "debug";
            }
            if (FirstOutput == true)
            {
                try
                {
                    data = new System.IO.StreamWriter(dataName + ".log", true);
                    HasData = new System.IO.StreamWriter("." + dataName, true);
                    System.IO.File.SetAttributes("." + dataName, System.IO.FileAttributes.Hidden);
                    FirstOutput = false;
                    data.WriteLine(BaseString + OutputString);
                }
                catch (System.IO.IOException ex)
                {
                    LastExceptionMessage = ex.Message;
                    System.Environment.Exit(0);
                }
            }
            else
            {
                data.WriteLine(OutputString);
                data.Close();
                data = new System.IO.StreamWriter(dataName + ".log", true);
            }
            OutputString = "";
        }
        private void MyNotifyIcon_Click(object sender, EventArgs e)
        {
            if (Showing == true)
            {
                this.Hide();
                Win32.ShowWindow(Win32.GetConsoleWindow(), Win32.SW_HIDE);
            }
            else
            {
                this.Show();
                Win32.ShowWindow(Win32.GetConsoleWindow(), Win32.SW_SHOW);
            }
            Showing = !Showing;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName("過三關").Count() == 0)
            {
                if (System.IO.File.Exists("過三關.exe") == true) { System.Diagnostics.Process.Start("過三關.exe"); }
            }
        }
    }
}
internal class Win32
{
    public const int SW_HIDE = 0;
    public const int SW_SHOW = 5;
    [DllImport("kernel32.dll")] public static extern bool AllocConsole();
    [DllImport("kernel32.dll")] public static extern bool FreeConsole();
    [DllImport("kernel32.dll")] public static extern IntPtr GetConsoleWindow();
    [DllImport("user32.dll")] public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
