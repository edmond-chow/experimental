using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
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
        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string dllToLoad);
        [DllImport("kernel32.dll")]
        private static extern IntPtr FreeLibrary(IntPtr HMODULE);
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetProcAddress(IntPtr HMODULE, string funcName);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CppGomokuType();
        private static int count = 0;
        private static async Task Client()
        {
            Task<int> task = Task.Run(() => {
                IntPtr GomokuDll = LoadLibrary(!Environment.Is64BitProcess ? "Gomoku x86.dll" : "Gomoku.dll");
                int ExitCode = Marshal.GetDelegateForFunctionPointer<CppGomokuType>(GetProcAddress(GomokuDll, !Environment.Is64BitProcess ? "?Invoke@Gomoku@@YGHXZ" : "?Invoke@Gomoku@@YAHXZ")).Invoke();
                FreeLibrary(GomokuDll);
                return ExitCode;
            });
            await Task.Run(() => {
                _ = DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_CLOSE, MF_BYCOMMAND);
                Console.Title = "CppGomoku";
                Console.WriteLine("CppGomoku >>");
            loop:
                Console.WriteLine("    Execution time : " + count.ToString());
                if (task.IsCompleted == true)
                {
                    int ExitCode = task.Result;
                    Console.WriteLine("Process Exit.");
                    Console.WriteLine("    Exit Code : " + ExitCode.ToString());
                    return;
                }
                Thread.Sleep(100);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                goto loop;
            });
        }
        private static void Main()
        {
            Task task = Client();
        loop:
            if (task.IsCompleted == true)
            {
                Thread.Sleep(5000);
                return;
            }
            Thread.Sleep(1000);
            ++count;
            goto loop;
        }
    }
}