﻿
/* ================= 예제 4.18 ToString을 재정의한 Point ================= */

public class Point
{
    int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return "X: " + x + ", Y: " + y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point pt = new Point(5, 10);
        Console.WriteLine(pt.ToString());
    }
}
