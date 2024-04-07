
/* ================= 20.7 Interceptor (컴파일 시점에 메서드 호출 재작성) ================= */

using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.ProgramMethod();
            //      |- 위의 "P" 위치가 13번째 줄, 21번째 칼럼에 위치
        }


        static void ProgramMethod()
        {
            Console.WriteLine("Program Method");
        }
    }
}