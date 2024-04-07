
/* ================= 17.12 localsinit 플래그 내보내기 무시(Suppress emitting localsinit flag) ================= */

using System.Runtime.CompilerServices;

class Program
{
    [SkipLocalsInit]
    unsafe static void Main(string[] args)
    {
        int i = 5;
        char c;

        Console.WriteLine(i);
        FillChar(out c);

        LocalsInitStackAlloc();
    }

    private static void FillChar(out char c)
    {
        c = 'a';
    }

    [SkipLocalsInitAttribute]
    unsafe static void LocalsInitStackAlloc()
    {
        var arr = stackalloc int[1000];

        for (int i = 0; i < 1000; i++)
        {
            Console.Write($"{arr[i]},");
        }
    }
}
