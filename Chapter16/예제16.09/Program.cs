﻿
/* ================= 16.9 ??= (널 병합 할당 연산자) ================= */

class Program
{
    static void Main(string[] args)
    {
        {
            string txt = null;
            if (txt == null)
            {
                txt = "(기본값)";
            }

            Console.WriteLine(txt);
            txt ??= "";
            Console.WriteLine(txt);
        }

        Console.WriteLine();

        {
            string txt = null;

            txt = txt ?? "test";
            txt ??= "test";

            Console.WriteLine(txt);

            string result = txt ??= "test";
            Console.WriteLine(txt);
        }

    }
}
