
/* ================= 예제 5.9: #if/#endif 전처리기 대신 Conditional 특성 사용 ================= */

using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        OutputText();
    }

    [Conditional("DEBUG")]
    static void OutputText()
    {
        Console.WriteLine("디버그 빌드");
    }
}
