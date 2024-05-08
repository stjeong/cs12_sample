
/* ================= 예제 10.5: ReadAllText 메서드를 비동기로 처리 ================= */

namespace ConsoleApp1;

class Program
{
    static async Task Main(string[] args)
    {
        string fileText = await ReadAllTextAsync(@"C:\windows\system32\drivers\etc\HOSTS");
        Console.WriteLine(fileText);
    }

    static Task<string> ReadAllTextAsync(string filePath)
    {
        return Task.Factory.StartNew(() =>
        {
            return File.ReadAllText(filePath);
        });
    }
}
