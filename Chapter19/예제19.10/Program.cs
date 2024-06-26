﻿
/* ================= 19.10 메서드 매개 변수에 대한 nameof 지원 확장 ================= */

using System.Runtime.CompilerServices;

CallTest("test");

[Arg(nameof(msg))]
static void CallTest(string msg)
{
    Console.WriteLine($"{nameof(msg)}: {msg}");
}

public class ArgAttribute : Attribute
{
    public ArgAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}

public static class MyDebug
{
    public static void Assert(bool condition, [CallerArgumentExpression(nameof(condition))] string? message = null)
    {
        if (condition == false)
        {
            Console.WriteLine("Assert failed: " + message);
        }
    }
}