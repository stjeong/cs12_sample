﻿
/* ================= 예제 6.57: 리플렉션 실습용 코드 ================= */

namespace ConsoleApp1;

public class SystemInfo
{
    bool _is64Bit;

    public SystemInfo()
    {
        _is64Bit = Environment.Is64BitOperatingSystem;
        Console.WriteLine("SystemInfo created.");
    }

    public void WriteInfo()
    {
        Console.WriteLine("OS == {0}bits", (_is64Bit == true) ? "64" : "32");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SystemInfo sysInfo = new SystemInfo();
        sysInfo.WriteInfo();
    }
}
