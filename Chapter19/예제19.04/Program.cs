
/* ================= 19.4 shift 연산자 개선 ================= */

internal class Program
{
    static void Main(string[] args)
    {
        {
            int n = -2147483648;
            n = n >> 1;
            Console.WriteLine(n);
        }

        {
            int n = -2147483648;
            n = n >>> 1;
            Console.WriteLine(n);
        }

        {
            int n = -2147483648;
            uint result = TripleRightShift((uint)n, 1);
            Console.WriteLine(result);
        }
        
        {
            Int3 n = 1;
            for (int i = 1; i <= 7; i++)
            {
                n = n << i;
                Console.WriteLine($"{i} shifted: {n}");
            }
        }

        {
            Int3 n = 1;
            Int3 shiftAmount = 3;
            n = n << shiftAmount;
        }
    }

    static uint TripleRightShift(uint number, int shift)
    {
        return ((uint)number >> shift);
    }
}

public struct Int3
{
    int value;
    public const int MaxValue = 8_388_607;
    public const int MinValue = -8_388_608;

    public Int3(int value)
    {
        this.value = (value > 0) ? value % (MaxValue + 1) 
                                : -((-value) % (MaxValue + 2));
    }

    public static implicit operator Int3(int value) => new Int3(value);

    public static Int3 operator checked ++(Int3 lhs)
    {
        if (lhs.value + 1 > MaxValue)
        {
            throw new OverflowException((lhs.value + 1).ToString());
        }

        return new Int3(lhs.value + 1);
    }

    public static Int3 operator ++(Int3 lhs) => new Int3(lhs.value + 1);

    public static Int3 operator <<(Int3 lhs, int shiftAmount)
    {
        return new Int3(lhs.value << shiftAmount);
    }

    public static Int3 operator <<(Int3 lhs, Int3 shiftAmount)
    {
        return new Int3(lhs.value << shiftAmount.value);
    }

    public static Int3 operator >>(Int3 lhs, int shiftAmount)
    {
        return new Int3(lhs.value >> shiftAmount);
    }

    public static Int3 operator >>(Int3 lhs, Int3 shiftAmount)
    {
        return new Int3(lhs.value >> shiftAmount.value);
    }

    public override string ToString()
    {
        return $"{value}";
    }
}