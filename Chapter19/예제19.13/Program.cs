public class Program
{
    static Action<string>? _action;

    public static void Main()
    {
        TestMethod();
    }

    static void TestMethod()
    {
        if (_action == null)
        {
            _action = Output;
        }

        _action("Hello World!");
    }

    static void Output(string text)
    {
        Console.WriteLine(text);
    }
}