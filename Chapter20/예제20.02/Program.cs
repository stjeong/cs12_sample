
/* ================= 20.2 기본 생성자 ================= */

{
    PersonDTO p = new PersonDTO("John", 42);
    Console.WriteLine($"{p.GetName()}, {p.GetAge()}"); // 출력 결과: John, 0
}

{
    PersonDTO2 p = new PersonDTO2("John");
    PersonDTO2 p2 = p with { Age = 43 };

    Console.WriteLine($"{p2.Name}, {p2.Age}");
}

public class PersonDTO(string name, int age)
{
    int age = 0; // 멤버 필드로 동일한 이름을 정의한 경우, 기본 생성자의 age와는 별개로 동작

    public int Age { get; private set; } = age; // 기본 생성자의 age와 연동
                                                // 이런 경우 age를 this.age로 바꿔쓸 수 없다.

    public string GetName()
    {
        return name; // class 정의 내에서 사용할 수 있는 변수처럼 name 사용
                     // 역시 this.name으로 바꿔쓸 수 없다.
    }

    public int GetAge() => age; // 반면 이 곳의 age는 멤버 필드인 age와 연동하기 때문에,
                                // this.age로 바꿔쓸 수 있다.
}


public struct PersonDTO2(string name, int age)
{
    public PersonDTO2(string name) : this(name, 0) { }

    public string Name = name;
    public int Age { get; init; } = age;
}

#pragma warning disable CS9113 // Parameter is unread.
public struct PersonDTO3(string Name, int Age)
#pragma warning restore CS9113 // Parameter is unread.
{
    public PersonDTO3(string Name) : this(Name, 0) { }
}