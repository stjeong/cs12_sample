
/* ================= 19.3 사용자 정의 checked 연산자 ================= */

internal class Program
{
    static void Main(string[] args)
    {
        {
            Int3 n = new Int3(8_388_607);
            Console.WriteLine(n);
        }

        {
            Int3 n = new Int3(8_388_608);
            Console.WriteLine(n);
        }

        {
            Int3 n = new Int3(8_588_608);
            Console.WriteLine(n);
        }

        {
            Int3 n = new Int3(-8388607);
            Console.WriteLine(n);
        }

        {
            Int3 n = new Int3(-8388608);
            Console.WriteLine(n);
        }

        {
            Int3 n = new Int3(-8388609);
            Console.WriteLine(n);
        }

        {
            Int3 n = new Int3(-8588609);
            Console.WriteLine(n);
        }
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

    public override string ToString()
    {
        return $"{value}";
    }
}