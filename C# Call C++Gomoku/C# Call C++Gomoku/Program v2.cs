using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
namespace CSharp_Call_CppGomoku
{
    internal class Program
    {
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;
        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static volatile int count = 0;
        private static async Task<int> MainAsyncTask()
        {
            return await Task.Run(() => {
                Process process = Process.Start(!Environment.Is64BitProcess ? "Gomoku x86.exe" : "Gomoku.exe");
                while (!process.WaitForExit(1000)) { ++count; }
                return process.ExitCode;
            });
        }
        private static void Main()
        {
            Task<int> task = MainAsyncTask();
            _ = DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_CLOSE, MF_BYCOMMAND);
            Console.Title = "CppGomoku";
            Console.WriteLine("CppGomoku >>");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            while (!task.IsCompleted)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine("    Execution time : " + count.ToString());
                Thread.Sleep(100);
            }
            Console.WriteLine("Process Exit.");
            Console.WriteLine("    Exit Code : " + task.Result.ToString());
            Thread.Sleep(5000);
        }
    }
}