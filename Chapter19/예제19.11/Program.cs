
/* ================= 19.11 속성 및 필드에 지정할 수 있는 required 예약어 추가 ================= */

using System.Diagnostics.CodeAnalysis;

Person p = new Person { Age = 62, FirstName = "Anders", LastName = "Hejlsberg" };

Employee e = new Employee("Anders") { Age = 62 };
Employee e2 = new Employee("Anders");

Student lucy = new Student { Age = 21, Name = "Lucy" };

// 하나라도 빼먹으면, 컴파일 에러: error CS9035: Required member 'Person.Age' must be set in the object initializer or attribute constructor.
// Person p1 = new Person { FirstName = "Anders", LastName = "Hejlsberg" };

//public class Student
//{
//    public int Age { get; init; }
//    public string Name { get; init; }

//    public Student(int age, string name)
//    {
//        this.Age = age;
//        this.Name = name;   
//    }
//}

public class Student
{
    public required int Age { get; init; }
    public required string Name { get; init; }
}

public class Person
{
    public required int Age;

    public required string FirstName { get; init; }
    public string MiddleName { get; init; } = "";
    public required string LastName { get; init; }
}

public class Employee
{
    public required int Age;

    public string Name { get; }

    [SetsRequiredMembers]
    public Employee(string name)
    {
        this.Name = name;
    }
}

public class Salesman : Employee
{
    // 연동하려는 부모 클래스의 생성자가 SetsRequiredMembers 특성을 지정했으므로!
    // 만약 자식 클래스에서 지정하지 않으면 "CS9039 This constructor must add 'SetsRequiredMembers' because it chains to a constructor that has that attribute." 컴파일 오류
    [SetsRequiredMembers]
    public Salesman(string name) : base(name)
    {
    }
}