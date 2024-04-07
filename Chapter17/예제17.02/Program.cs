
/* ================= 17.2 대상에 따라 new 식 추론(Target-typed new expressions) ================= */

class Program
{
    static void Main(string[] args)
    {
        Point p = new(5, 6);

        var linePt = new Point[]
        {
            new(5, 6),
            new() { X = 7, Y = 0 },
        };

        var dict = new Dictionary<Point, bool>()
        {
            [new(5, 6)] = true,
            [new(7, 0)] = true,
            [new(7, 3)] = false,
            [new() { X = 3, Y = 2 }] = false,
        };
    }
}

public record Point(int X, int Y)
{
    public Point() : this(0, 0) { }
}
