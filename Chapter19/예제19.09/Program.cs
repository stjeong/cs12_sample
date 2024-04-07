
/* ================= 19.9 파일 범위 내에서 유효한 타입 정의 ================= */

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// private class MyPrivateType { } // error CS1527: Elements defined in a namespace cannot be explicitly declared as private, protected, protected internal, or private protected

public class MyPublicType { }
internal class MyInternalType { }

file class PrivateClass { }

class Test
{
    // 컴파일 오류: Error CS9051 File-local type 'TestLocal' cannot be used in a member signature in non-file-local type 'Test'.
    // TestLocal _tl; // 멤버 필드로는 사용할 수 없고,

    public Test()
    {
        TestLocal t2 = new TestLocal(); // 메서드 내에서는 사용 가능
    }

    // 컴파일 오류: File-local type 'TestLocal' cannot be used in a member signature in non-file-local type 'Test'.
    // public TestLocal Get() => new TestLocal(); // 메서드의 반환 타입으로 사용할 수 없음.                          
}

// file class 유형은 반드시 file class 타입에서만 상속 가능
file class LocalFromLocal : TestLocal
{
#pragma warning disable CS8618, CS0169 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    TestLocal t1; // file class 유형에서는 필드로 정의하는 것도 가능
#pragma warning restore CS8618, CS0169 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public TestLocal Get() => new TestLocal(); // 메서드의 반환 타입으로 사용하는 것도 가능
}

// 그렇지 않은 경우 컴파일 오류 - error CS9053: 파일 로컬 형식 'TestLocal'은(는) 파일 로컬 형식 'ClassFromLocal'이(가) 아닌 기본 형식으로 사용할 수 없습니다.
// class ClassFromLocal : TestLocal { }


file class TestLocal { }