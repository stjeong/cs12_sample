﻿
/* ================= 예제 5.17: 스택 사용 ================= */

class Program
{
    static void Main(string[] args)
    {
        int result = Sum(5, 6);
        Console.WriteLine(result);
    }

    private static int Sum(int v1, int v2)
    {
        int v3 = v1 + v2;
        return v3;
    }
}
