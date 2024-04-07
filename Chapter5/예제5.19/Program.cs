
/* ================= 예제 5.18: Sum과 InnerSum의 스택 사용 ================= */

class Program
{
    static void Main(string[] args)
    {
        int result = Sum(5, 6);
        Console.WriteLine(result);
    }

    private static int Sum(int v1, int v2)
    {
        int sum = InnerSum(v1, v2);
        return sum;
    }

    private static int InnerSum(int v1, int v2)
    {
        int sum = v1 + v2;
        return sum;
    }
}
