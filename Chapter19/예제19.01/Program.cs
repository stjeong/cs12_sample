
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.AddRange(new[] { 1, 2, 3 });

        Console.WriteLine(list.Sum());

        Console.WriteLine(list.합계());
    }
}

public static class MyLinqExtension
{
    public static T 합계<T>(this IEnumerable<T> arg) where T : struct, IAdditionOperators<T, T, T>
            
    {
        T sum = default;

        foreach (T item in arg)
        {
           sum = sum + item; // C# 10 컴파일 오류 - error CS0019: Operator '+' cannot be applied to operands of type 'T' and 'T'
        }

        return sum;
    }
}

public interface IMessage
{
    public static int None = 0; // 정적 필드는 abstract 키워드를 사용할 수 없다.
    static abstract void All(); // 정적 메서드는 가능
    public static abstract int Any { get; } // 속성 역시 메서드이므로 가능
}

public class Message : IMessage
{
    public static int Any => 5; // 상위 인터페이스에서 abstract 였으므로 반드시 구현

    public static void All() // 상위 인터페이스에서 abstract 였으므로 반드시 구현
    {
        Console.WriteLine("All called");
    }
}
