internal class Program
{
    public static void Main(string[] args)
    { 
        ProcessIn(5); 
        ProcessRefReadonly(5);
    }

    public static void ProcessIn(in int instance) { }

    public static void ProcessRefReadonly(ref readonly int instance) { }
}
