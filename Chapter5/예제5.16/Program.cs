﻿
/* ================= 예제 5.15: throw와 throw ex의 차이 ================= */

class Program
{
    static void Main(string[] args)
    {
        try
        {
            HasProblem();
        }
        catch (System.Exception /* ex */)
        {
            throw; // 또는 throw ex;}
        }
    }

    private static void HasProblem()
    {
        string txt = null;
        Console.WriteLine(txt.ToUpper());
    }
}
