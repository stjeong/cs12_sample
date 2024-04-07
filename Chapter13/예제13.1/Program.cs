
/* ================= 13.1 Main 메서드에 async 예약어 허용 ================= */

namespace ConsoleApp1;

class Program
{
    //static void Main(string[] args)
    //{
    //    MainAsync();
    //    MainAsync().GetAwaiter().GetResult();
    //}

    //static async Task Main(string [] args)
    //{
    //    WebClient wc = new WebClient();
    //    string text = await wc.DownloadStringTaskAsync("https://www.microsoft.com");
    //    Console.WriteLine(text);
    //}

    static HttpClient _client = new HttpClient();

    static async Task Main(string[] args) => Console.WriteLine(await _client.GetStringAsync("https://www.microsoft.com"));

    private static async Task MainAsync()
    {
        string text = await _client.GetStringAsync("https://www.microsoft.com");
        Console.WriteLine(text);
    }
}
