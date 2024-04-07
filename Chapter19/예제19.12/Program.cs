
/* ================= 19.12 구조체 필드의 기본값 자동 초기화 (auto-default structs) ================= */

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
#pragma warning disable CS0649 // Field 'Student.Name' is never assigned to, and will always have its default value null
    public string? Name;
#pragma warning restore CS0649 // Field 'Student.Name' is never assigned to, and will always have its default value null
}