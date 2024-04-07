MyStruct mrs = new MyStruct();

public struct MyStruct
{
    public int x, y;
    public int z = 0;

    public MyStruct()
    {
        x = 0;
    }
}

public class MyClass
{
    public int x, y;
    public int z = 0;

    public MyClass()
    {
        x = 0;
    }
}

//record class Student(int Age)
//{
//    public string? Name;
//}

record struct Student(int Age)
{
    public string? Name;
}