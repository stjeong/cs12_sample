﻿
/* ================= 12.9 리터럴에 대한 표현 방법 개선 ================= */

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 10000000;
        int number2 = 10_000_000;
        int number3 = 1_0_0_0_0_000;

        Console.WriteLine(number1);
        Console.WriteLine(number2);
        Console.WriteLine(number3);

        uint hex1 = 0xFFFFFFFF;
        uint hex2 = 0xFF_FF_FF_FF;
        uint hex3 = 0xFFFF_FFFF;

        Console.WriteLine(hex1);
        Console.WriteLine(hex2);
        Console.WriteLine(hex3);

        uint bin1 = 0b0001000100010001; // 2진 비트열로 숫자 데이터 정의
        uint bin2 = 0b0001_0001_0001_0001; // 4자리마다 구분자 사용해 가독성을 높임

        Console.WriteLine(bin1);
        Console.WriteLine(bin2);
    }
}
