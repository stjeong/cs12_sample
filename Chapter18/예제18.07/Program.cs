﻿
/* ================= 18.7 호줄자 인수 식(CallerArgumentExpression) ================= */

using System.Runtime.CompilerServices;

MyDebug.Assert(args.Length >= 1);

public static class MyDebug
{
    public static void Assert(bool cond, [CallerArgumentExpression("cond")] string? msg = null)
    {
        if (cond == false)
        {
            Console.WriteLine("Assert failed: " + msg);
        }
    }
}
