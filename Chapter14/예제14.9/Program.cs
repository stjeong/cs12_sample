class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();

        // C# 7.1 이전에는 컴파일 오류
        // 첫 번째 인자에 이름을 지정했으므로 두 번째 인자도 이름을 지정해야 함
        p.Output(name: "Tom", 16, address: "Tibet");
    }

    class Person
    {
        public void Output(string name, int age = 0, string address = "Korea")
        {
            Console.WriteLine(string.Format("{0}: {1} in {2}", name, age, address));
        }
    }
}
