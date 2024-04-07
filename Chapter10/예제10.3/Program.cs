
/* ================= 예제 10.3: 동기식 코드 ================= */

using System.Net;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
#pragma warning disable SYSLIB0014
        WebClient wc = new WebClient();
#pragma warning restore SYSLIB0014        
        string text = wc.DownloadString("https://www.naver.com");
        Console.WriteLine(text);
    }
}

