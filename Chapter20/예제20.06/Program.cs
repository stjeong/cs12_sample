
/* ================= 20.6 ref readonly 매개 변수 ================= */

internal class Program
{
    public static void Main(string[] args)
    { 
        ProcessIn(5); 
#pragma warning disable CS9193 // Argument should be a variable because it is passed to a 'ref readonly' parameter
        ProcessRefReadonly(5);
#pragma warning restore CS9193 // Argument should be a variable because it is passed to a 'ref readonly' parameter
    }

    public static void ProcessIn(in int instance) { }

    public static void ProcessRefReadonly(ref readonly int instance) { }
}
