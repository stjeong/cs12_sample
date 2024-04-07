using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Run at Main");
    }
}

class Module
{
    [ModuleInitializer]
    internal static void DllMain()
    {
        Console.WriteLine("Run at ModuleInitializer");
    }
}
