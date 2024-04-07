
/* ================= 20.5 컬렉션 식과 스프레드 연산자 ================= */

using System;
using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        {
            // C# 11 이전
            int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8 };

            // C# 12부터 추가로 지원
            int[] a2 = [1, 2, 3, 4, 5, 6, 7, 8];

            // C# 11 이하에서는 Span 초기화는 나눠서 했던 반면, 
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Span<int> ints1 = a;

            // C# 12부터는 컬렉션 리터럴을 활용해 한 줄로 처리 가능
            Span<int> ints2 = [1, 2, 3, 4, 5, 6, 7, 8];

            // "IEnumerable + Add 확장 메서드" 또는 ICollection 인터페이스를 구현한 경우
            // C# 11 이하는 컬렉션 초기화 구문을 사용,
            MyType list1 = new MyType() { 1, 2, 3, 4, 5, 6, 7, 8 };

            // C# 12부터는 컬렉션 리터럴 사용 가능
            MyType list2 = [1, 2, 3, 4, 5, 6, 7, 8];

            // 가변 배열의 경우에도 컬렉션 리터럴 사용 가능
            int[][] jaggedArray = [[1, 2, 3], [4], [5, 6]];
        }

        {
            // 3항 연산자에도 쓸 수 있고,
            List<int> list = (Environment.OSVersion.Version.Major > 4) ? [1, 2] : [3, 4];

            ListArray([1, 2, 3]); // 함수의 인자로 직접 넘기는 것이 가능하며,

            Func<List<int>> GetDefaults = () => [1, 2, 3]; // 람다 함수에도 사용 가능

            Array.ForEach([3, 4, 5], (elem) => Console.Write($"{elem}, ")); // 요소에 대한 타입 추론 지원, int[]로 결정

            static void ListArray(List<int> list)
            {
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        {
            int[] array1 = [1, 2, 3];
            int[] array2 = [4];
            int[] array3 = [5, 6];
            int[] array = [0, .. array1, .. array2, .. array3];
            Array.ForEach(array, (elem) => Console.Write($"{elem}, ")); // 출력 결과: 0, 1, 2, 3, 4, 5, 6

            Console.WriteLine();

            Array.ForEach([0, .. array1], (elem) => Console.Write($"{elem}, "));
        }
    }
}

public class TestType
{
    // 람다 함수에서도 사용 가능
    public List<int> GetDefaults => [1, 2, 3];

    // 하지만, 메서드의 (상수식을 요구하는) 기본 값으로는 설정할 수 없음
    // public void Output(int[] elems = [1, 2, 3]) // 컴파일 오류: error CS1736: Default parameter value for 'elems' must be a compile-time constant
    // {
    // }
}


public class MyType : IEnumerable
{
    public List<int> Values { get; set; } = new List<int>();

    public IEnumerator GetEnumerator()
    {
        return Values.GetEnumerator();
    }
}

public static class MyExtension
{
    public static void Add(this MyType type, int value)
    {
        type.Values.Add(value);
    }
}