
/* ================= 예제 8.5: 익명 메서드를 람다 구문의 메서드로 대체 ================= */

class Program
{
    delegate int? MyDivide(int a, int b);

    static void Main(string[] args)
    {
        MyDivide myFunc = (a, b) =>
        {
            if (b == 0)
            {
                return null;
            }
            return a / b;
        };

        Console.WriteLine("10 / 2 == " + myFunc(10, 2)); // 출력 결과: 10 / 2 == 5
        Console.WriteLine("10 / 0 == " + myFunc(10, 0)); // 출력 결과: 10 / 2 ==
    }
}

