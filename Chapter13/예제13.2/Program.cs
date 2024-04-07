
using System.Numerics;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        GenericTest<int> t = new GenericTest<int>();
        Console.WriteLine(t.GetDefaultValue());

        int intValue = default;
        BigInteger bigIntValue = default;

        Console.WriteLine(intValue);        // 출력 결과: 0
        Console.WriteLine(bigIntValue);     // 출력 결과: 0

        string txt = default;
        Console.WriteLine(txt ?? "(null)"); // 출력 결과: (null)
    }
}

class GenericTest<T>
{
    public T GetDefaultValue()
    {
        return default;
    }
}
