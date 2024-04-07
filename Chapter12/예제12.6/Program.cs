
namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Program pg = new Program();

        pg.AnonymousMethodTest();
        pg.LambdaMethodTest();
        pg.LocalFuncTest();
        pg.LocalLambdaFuncTest();
    }

    delegate (bool, int) MyDivide(int a, int b);

    void AnonymousMethodTest()
    {
        MyDivide func = delegate (int a, int b)
        {
            if (b == 0)
            {
                return (false, 0);
            }

            return (true, a / b);
        };

        Console.WriteLine(func(10, 5));
        Console.WriteLine(func(10, 0));
    }

    void LambdaMethodTest()
    {
        MyDivide func = (a, b) =>
        {
            if (b == 0)
            {
                return (false, 0);
            }

            return (true, a / b);
        };

        Console.WriteLine(func(10, 5));
        Console.WriteLine(func(10, 0));
    }

    void LocalFuncTest()
    {
        (bool, int) func(int a, int b)
        {
            if (b == 0)
            {
                return (false, 0);
            }

            return (true, a / b);
        };

        Console.WriteLine(func(10, 5));
        Console.WriteLine(func(10, 0));
    }

    void LocalLambdaFuncTest()
    {
        (bool, int) func(int a, int b) =>
            (b == 0) ? (false, 0) : (true, a / b);

        Console.WriteLine(func(10, 5));
        Console.WriteLine(func(10, 0));
    }
}
