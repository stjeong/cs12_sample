
/* ================= 12.7 사용자 정의 Task 타입을 async 메서드의 반환 타입으로 사용 가능 ================= */

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //    {
        //        Task<(string, int tid)> result =
        //            FileReadAsync(@"C:\windows\system32\drivers\etc\HOSTS");

        //        int tid = Thread.CurrentThread.ManagedThreadId;
        //        Console.WriteLine($"MainThreadID: {tid}, AsyncThreadID: {result.Result.tid}");
        //    }

        //    {
        //        Task<(string, int tid)> result =
        //FileReadAsync(@"C:\windows\system32\drivers\etc\HOSTS");

        //        int tid = Thread.CurrentThread.ManagedThreadId;
        //        Console.WriteLine($"MainThreadID: {tid}, AsyncThreadID: {result.Result.tid}");
        //    }

        {
            ValueTask<(string, int tid)> result = FileReadAsync2(@"C:\windows\system32\drivers\etc\HOSTS");

            int tid = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"MainThreadID: {tid}, AsyncThreadID: {result.Result.tid}");
        }

        {
            ValueTask<(string, int tid)> result = FileReadAsync2(@"C:\windows\system32\drivers\etc\HOSTS");

            int tid = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"MainThreadID: {tid}, AsyncThreadID: {result.Result.tid}");
        }
    }

    static string _fileContents = string.Empty;
    private static async Task<(string, int)> FileReadAsync(string filePath)
    {
        if (string.IsNullOrEmpty(_fileContents) == false)
        {
            return (_fileContents, Thread.CurrentThread.ManagedThreadId);
        }

        _fileContents = await ReadAllTextAsync(filePath);
        return (_fileContents, Thread.CurrentThread.ManagedThreadId);
    }

    private static async ValueTask<(string, int)> FileReadAsync2(string filePath)
    {
        if (string.IsNullOrEmpty(_fileContents) == false)
        {
            return (_fileContents, Thread.CurrentThread.ManagedThreadId);
        }

        _fileContents = await ReadAllTextAsync(filePath);
        return (_fileContents, Thread.CurrentThread.ManagedThreadId);
    }

    static Task<string> ReadAllTextAsync(string filePath)
    {
        return Task.Factory.StartNew(() =>
        {
            return File.ReadAllText(filePath);
        });
    }
}
