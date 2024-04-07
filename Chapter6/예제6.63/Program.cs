

/* ================= 예제 6.63: BigInteger 사용 ================= */

using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger int1 = BigInteger.Parse("12345678901234567890");
        BigInteger int2 = BigInteger.Parse("98765432109876543210");

        Console.WriteLine(int1 + int2); // 출력 결과: 111111111011111111100

        BigInteger int3 = 9223372036854775807;
    }
}

