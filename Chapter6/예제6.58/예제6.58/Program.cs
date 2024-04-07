
/* ================= 예제 6.56: AppDomain에 어셈블리를 로드하는 방법 ================= */

using System.Runtime.Remoting;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        AppDomain newAppDomain = AppDomain.CurrentDomain;
        string dllPath = GetClassLibaryPath();
        if (string.IsNullOrEmpty(dllPath) == true)
        {
            return;
        }

        ObjectHandle objHandle
            = newAppDomain.CreateInstanceFrom(dllPath, "ClassLibrary1.Class1");

        Console.WriteLine("ClassLibrary1.dll 파일이 현재 프로세스에 로드되었습니다.");
    }

    private static string GetClassLibaryPath()
    {
        string path = Path.GetDirectoryName(typeof(Program).Assembly.Location);
        string libPath = Path.Combine(path, "..", "..", "..", "..", "ClassLibrary1", "bin", "Debug", "net7.0", "ClassLibrary1.dll");

        if (File.Exists(libPath) == false)
        {
            Console.WriteLine("File Not Found: " + libPath);
            return null;
        }

        return libPath;
    }
}


