﻿
/* ================= 예제 5.10: Console, Debug, Trace 타입을 사용한 출력 예제 ================= */

using System.Diagnostics;


// DebugView
// https://learn.microsoft.com/en-us/sysinternals/downloads/debugview

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("사용자 화면 출력");
        Debug.WriteLine("디버그 화면 출력 - Debug");
        Trace.WriteLine("디버그 화면 출력 - Trace");
    }
}
