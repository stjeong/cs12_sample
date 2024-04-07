
/* ================= 9.3 동시성 컬렉션 ================= */

internal class Program
{
    static List<int> list = new List<int>();

    static void Main(string[] args)
    {
        list.AddRange(Enumerable.Range(1, 100));

        ThreadPool.QueueUserWorkItem((arg) =>
        {
            ChangeList();
        });

        ThreadPool.QueueUserWorkItem((arg) =>
        {
            EnumerateList();
        });

        Console.ReadLine();
    }

    private static void EnumerateList()
    {
        lock (list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    private static void ChangeList()
    {
        for (int i = 1; i <= 10; i++)
        {
            lock (list)
            {
                list.Add(100 + i);
            }

            Thread.Sleep(16);
        }
    }
}
