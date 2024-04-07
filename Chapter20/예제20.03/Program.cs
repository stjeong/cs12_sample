
using Person = (int Age, string Name);
using UnnamedPerson = (int, string);
using unsafe BytePtr = byte*;

using NullableInteger = int?;

// using Utf16String = System.String?; // 컴파일 에러: error CS9132: Using alias cannot be a nullable reference type.

internal class Program
{
    private unsafe static void Main(string[] args)
    {
        {
            Person person = new Person { Age = 1, Name = "Anders" };
            Console.WriteLine(person.Age);
        }

        {
            Person person = (1, "Anders");
            Console.WriteLine(person.Age);
        }

        {
            UnnamedPerson person = (1, "Anders");
            Console.WriteLine(person.Item1); // Item1 == 첫 번째 int 요소 접근
        }

        {
            byte[] buffer = new byte[] { 1, 2, 3 };
            fixed (BytePtr ptr = buffer)
            {
                Console.WriteLine(*ptr); // 출력 결과: 1
            }
        }

        {
            Console.WriteLine(typeof(NullableInteger).FullName);
        }
    }
}


