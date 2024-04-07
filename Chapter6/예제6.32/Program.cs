
/* ================= 예제 6.31: 현재 컴퓨터에 할당된 IP 주소 출력 ================= */

using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string myComputer = Dns.GetHostName();

        Console.WriteLine("컴퓨터 이름: " + myComputer);

        IPHostEntry entry = Dns.GetHostEntry(myComputer);
        foreach (IPAddress ipAddress in entry.AddressList)
        {
            Console.WriteLine(ipAddress.AddressFamily + ": " + ipAddress);
        }
    }
}

