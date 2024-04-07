
/* ================= 예제 7.6: yield return을 이용한 자연수 표현 ================= */

namespace ConsoleApp1;

class YieldNaturalNumber
{
    public static IEnumerable<int> Next()
    {
        int _start = 0;
        while (true)
        {
            _start++;
            yield return _start;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        foreach (int n in YieldNaturalNumber.Next())
        {
            Console.WriteLine(n);
        }
    }
}
