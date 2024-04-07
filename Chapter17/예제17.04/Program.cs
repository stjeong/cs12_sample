
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Log("Main");
        Log(null);

        [Conditional("DEBUG")]
        static void Log([AllowNull] string text)
        // static void Log(string text)
        {
            string logText = $"[{Thread.CurrentThread.ManagedThreadId}] {text}";
            Console.WriteLine(logText);
        }

        MessageBox(IntPtr.Zero, "message", "title", 0);

        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        static extern int MessageBox(IntPtr h, string m, string c, int type);
    }
}

