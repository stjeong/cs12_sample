
/* ================= 12.10 패턴 매칭 ================= */

using System.Collections;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        AsyncMain().GetAwaiter().GetResult();
    }

    public static async Task AsyncMain()
    { 
        object obj = new List<string>();

        {
            List<string> list = obj as List<string>;
            list?.ForEach((e) => Console.WriteLine(e));
        }

        {
            if (obj is List<string> list)
            {
                list.ForEach((e) => Console.WriteLine(e));
            }
        }

        object[] objList = new object[] { 100, null, DateTime.Now, new ArrayList() };

        foreach (object item in objList)
        {
            if (item is 100) // 상수 패턴
            {
                Console.WriteLine(item);
            }
            else if (item is null)
            {
                Console.WriteLine("null");
            }
            else if (item is DateTime dt) // 타입 패턴(값 형식 가능)
            {
                Console.WriteLine(dt);
            }
            else if (item is ArrayList arr) // 타입 패턴(참조 형식 가능
            {
                Console.WriteLine(arr.Count);
            }
            else if (item is var elem)
            {
                Console.WriteLine(elem);
            }
        }

        foreach (object item in objList)
        {
            switch (item)
            {
                case 100:
                    break;

                case null:
                    break;

                case DateTime dt:
                    break;

                case ArrayList arr:
                    break;

                case var elem:
                    break;

            }
        }

        int j = 500;
        if (j > 300)
        {
        }
        else
        {
        }

        switch (j)
        {
            case int i when i > 300:
                break;

            default:
                break;
        }

        string text = "카카오";

        switch (text)
        {
            case var item when (await ContainsAt(item, "https://www.naver.com")):
                Console.WriteLine("In Naver");
                break;

            case var item when (await ContainsAt(item, "https://www.daum.net")):
                Console.WriteLine("In Daum");
                break;

            default:
                Console.WriteLine("None");
                break;
        }

        Action<(int, int)> detectZeroOR = (arg) =>
        {
            switch (arg)
            {
                case var r when r.Equals((0, 0)):
                case var r1 when r1.Item1 == 0:
                case var r2 when r2.Item2 == 0:
                    Console.WriteLine("Zero found.");
                    return;
            }

            Console.WriteLine("Both nonzero.");
        };

        detectZeroOR((0, 0));
        detectZeroOR((1, 0));
        detectZeroOR((0, 10));
        detectZeroOR((10, 15));
    }

    static HttpClient _client = new HttpClient();

    private async static Task<bool> ContainsAt(string item, string url)
    {
        string text = await _client.GetStringAsync(url);

        return text.IndexOf(item) != -1;
    }
}
