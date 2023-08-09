using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 過三關
{
    public partial class MainForm : Form
    {
        private string LastExceptionMessage = "";
        private bool IsTesting = false;
        private string dataName = "";
        private string temp = ".TicTacToe";
        private System.IO.StreamWriter tempData;
        public MainForm() { InitializeComponent(); }
        private void Form_FormClosing(object sender, FormClosingEventArgs e) { tempData.Close(); }
        private void Form_Load(object sender, EventArgs e)
        {
            this.Text = Basic.Title;
            if (System.Diagnostics.Process.GetProcessesByName("TicTacToeConsole").Count() != 0) { IsTesting = true; }
        }
        private void Basic_Click(object sender, EventArgs e) { this.Text = Basic.Title; }
        private void Basic_TicTacToeKeyDown(object sender, KeyEventArgs e)
        {
            this.Text = Basic.Title;
            if (e.KeyCode == Keys.A && System.IO.File.Exists("TicTacToeConsole.exe") == true && System.Diagnostics.Process.GetProcessesByName("TicTacToeConsole").Count() == 0)
            {
                if (Basic.Mode == TicTacToeLibrary.Base.TicTacToeMode.DebugAttack || Basic.Mode == TicTacToeLibrary.Base.TicTacToeMode.DebugDefend) { System.Diagnostics.Process.Start("TicTacToeConsole.exe", "Debug"); }
                else { System.Diagnostics.Process.Start("TicTacToeConsole.exe"); }
                IsTesting = true;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (IsTesting == true)
            {
                this.Hide();
                if (System.Diagnostics.Process.GetProcessesByName("TicTacToeConsole").Count() == 0)
                {
                    IsTesting = false;
                    string BaseString = "[Shutdown] on " + string.Format("{0:dd/MM/yyyy}", DateTime.Now) + " at " + string.Format("{0:HH:mm:ss}", DateTime.Now);
                    bool Shutdown = false;
                    if (System.IO.File.Exists(".console") == true)
                    {
                        System.IO.File.Delete(".console");
                        dataName = "console";
                        Shutdown = true;
                    }
                    if (System.IO.File.Exists(".debug") == true)
                    {
                        System.IO.File.Delete(".debug");
                        dataName = "debug";
                        Shutdown = true;
                    }
                    if (Shutdown == true)
                    {
                        System.IO.StreamWriter data = new System.IO.StreamWriter(dataName + ".log", true);
                        data.WriteLine(BaseString);
                        data.Close();
                        if (System.IO.File.Exists(".bugs") && dataName != "debug")
                        {
                            System.IO.File.Delete(".bugs");
                            System.IO.StreamWriter bugs = new System.IO.StreamWriter("bugs.log", true);
                            bugs.WriteLine(BaseString);
                            bugs.Close();
                        }
                    }
                }
            }
            else
            {
                this.Show();
                if (System.Diagnostics.Process.GetProcessesByName("TicTacToeConsole").Count() != 0) { IsTesting = true; }
            }
        }
        private void Basic_TicTacToeStartUp(object sender, TicTacToeLibrary.Base.TicTacToeStartUpEventArgs e)
        {
            try
            {
                string[] Lines = System.IO.File.ReadAllLines(temp);
                TicTacToeLibrary.Base.TicTacToeMode Mode = (TicTacToeLibrary.Base.TicTacToeMode)int.Parse(Lines[0]);
                TicTacToeLibrary.Base.TicTacToeBaseControl[] Player = new TicTacToeLibrary.Base.TicTacToeBaseControl[Lines.Length - 1];
                for (int i = 0; i < Lines.Length - 1; ++i) { Player[i] = (TicTacToeLibrary.Base.TicTacToeBaseControl)int.Parse(Lines[i + 1]); }
                Basic.SetBase(Mode, Player);
                this.Text = Basic.Title;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                LastExceptionMessage = ex.Message;
                goto AbnormalBase;
            }
            catch (System.IO.IOException ex)
            {
                LastExceptionMessage = ex.Message;
                Environment.Exit(0);
            }
            catch (System.InvalidCastException ex)
            {
                LastExceptionMessage = ex.Message;
                goto Abnormal;
            }
            catch (System.IndexOutOfRangeException ex)
            {
                LastExceptionMessage = ex.Message;
                goto Abnormal;
            }
            catch (System.OutOfMemoryException ex)
            {
                LastExceptionMessage = ex.Message;
                goto Abnormal;
            }
            goto General;
        Abnormal:
            System.IO.File.Delete(temp);
        AbnormalBase:
            tempData = new System.IO.StreamWriter(temp, true);
            System.IO.File.SetAttributes(temp, System.IO.FileAttributes.Hidden);
            tempData.Write(((int)Basic.Mode).ToString());
            tempData.Close();
        General:
            tempData = new System.IO.StreamWriter(temp, true);
            System.IO.File.SetAttributes(temp, System.IO.FileAttributes.Hidden);
        }
        private void Basic_TicTacToeNewGame(object sender, TicTacToeLibrary.Base.TicTacToeGameEventArgs e)
        {
            tempData.Close();
            System.IO.File.Delete(temp);
            tempData = new System.IO.StreamWriter(temp, true);
            System.IO.File.SetAttributes(temp, System.IO.FileAttributes.Hidden);
            tempData.Write(((int)e.Mode).ToString());
            tempData.Close();
            tempData = new System.IO.StreamWriter(temp, true);
        }
        private void Basic_TicTacToeNewRound(object sender, TicTacToeLibrary.Base.TicTacToeRoundEventArgs e)
        {
            tempData.WriteLine();
            tempData.Write(((int)e.HasClicked).ToString());
            tempData.Close();
            tempData = new System.IO.StreamWriter(temp, true);
        }
    }
}
