﻿
/* ================= 14.1 메서드의 매개변수에 in 변경자 추가 ================= */

class Program
{
    static void Main(string[] args)
    {
        Program pg = new Program();

        Vector v1 = new Vector();
        v1.X = 5;
        v1.Y = 7;
        pg.StructParam(in v1);

        // pg.ClassParam(in pg);
    }

    void StructParam(in /* ref + readonly */ Vector v)
    {
        // v.X = 5; // CS8332 Cannot assign to a member of variable 'in Vector' because it is a readonly variable
    }

    /*
    void StructParam(ref Vector p)
    {
    }

    void StructParam(out Vector p)
    {
    }
    */
}

struct Vector
{
    public int X;
    public int Y;
}

