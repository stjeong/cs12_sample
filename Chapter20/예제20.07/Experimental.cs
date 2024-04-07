using System.Runtime.CompilerServices;

namespace InterceptTest
{

    internal class Experimental
    {
        // [InterceptsLocation(@"...[실습 중인 소스 코드 경로]...\Chapter20\예제20.07\Program.cs", line: 13, character: 21)]
        public static void MyMethod() => Console.WriteLine("My Method");
    }
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class InterceptsLocationAttribute : Attribute
    {
        public InterceptsLocationAttribute(string filePath, int line, int character)
        {
        }
    }
}