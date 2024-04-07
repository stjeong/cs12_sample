
/* ================= 예제 4.2: Book 타입 정의 및 사용 ================= */

namespace ConsoleApp1;

class Program
{   
    static void Main(string[] args)
    {
        Book gulliver = new Book();
    }
}

#pragma warning disable CS0169
class Book
{
    string Title;
    decimal ISBN13;
    string Contents;
    string Author;
    int PageCount;
}
#pragma warning restore CS0169

