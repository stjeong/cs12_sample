class Program
{
    static void Main(string[] args)
    {
        // Matrix matrix = new Matrix();

        Matrix2x2 matrix = new Matrix2x2();
        Console.WriteLine($"{matrix.v1.X},{matrix.v1.Y}");
    }
}

ref struct Vector
{
    public int X;
    public int Y;

    public Vector(int x, int y) { X = x; Y = y; }
}


/*
class Matrix
{
    public Vector Rx = new Vector(1, 2);
    public Vector Ry = new Vector(10, 20);
}
*/

ref struct Matrix2x2
{
    public Vector v1 = new Vector(); // ref struct
    public Vector v2 = new Vector();

    public Matrix2x2() { } // 필드 초기화 코드가 있다면 반드시 생성자 포함
}
