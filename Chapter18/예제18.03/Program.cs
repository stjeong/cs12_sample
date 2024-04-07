
/* ================= 18.3 네임스페이스 개선 ================= */

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(args.Count()); // Console 타입과 Linq 확장 메서드 사용 가능
    }
}
