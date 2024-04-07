
/* ================= 14.6 3항 연산자에 ref 지원 ================= */

class Program
{
    static void Main(string[] args)
    {
        int part1 = 5;
        int part2 = 6;

        ref int result = ref (part1 != 0) ? ref part1 : ref part2; // C# 7.1 이하 버전에서는 컴파일 오류

        ((part1 != 0) ? ref part1 : ref part2) = 15; // C# 7.1 이하 버전에서는 컴파일 오류
        Console.WriteLine(part1); // 출력 결과 15
    }
}
