internal class Program
{
    static void Main(string[] args)
    {
        IntPtr p1 = new IntPtr(5);
        IntPtr p2 = new IntPtr(6);

        // C# 10 이하에서는 아래의 코드가 모두 컴파일 오류
        IntPtr p3 = p1 + p2; // error CS0019: Operator '+' cannot be applied to operands of type 'IntPtr' and 'IntPtr'
        IntPtr p4 = p1 - p2; // error CS0019: Operator '-' cannot be applied to operands of type 'IntPtr' and 'IntPtr'
        IntPtr p5 = p1 * p2; // error CS0019: Operator '*' cannot be applied to operands of type 'IntPtr' and 'IntPtr'
        IntPtr p6 = p1 / p2; // error CS0019: Operator '/' cannot be applied to operands of type 'IntPtr' and 'IntPtr'
    }
}
