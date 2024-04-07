
/* ================= 14.8 숫자 리터럴의 선행 밑줄 ================= */

class Program
{
    static void Main(string[] args)
    {
        {
            int number1 = 0x1_000;
            int number2 = 0x_1000; // C# 7.1 이전에는 컴파일 오류: Error CS1013 Invalid number

            int number3 = 0b1_000;
            int number4 = 0b_1000; // C# 7.1 이전에는 컴파일 오류: Error CS1013 Invalid number

            Console.WriteLine($"{number1}, {number2}, {number3}, {number4}");
        }

        {
            Person p = new Person();
            p.Output(name: "Tom", 16, address: "Tibet"); // C# 7.1 이전에는 컴파일 오류
                                                         // 첫 번째 인자에 이름을 지정했으므로 두 번째 인자도 이름을 지정해야 함
        }
    }

    class Person
    {
        public void Output(string name, int age = 0, string address = "Korea")
        {
            Console.WriteLine(string.Format("{0}: {1} in {2}", name, age, address));
        }
    }
}
