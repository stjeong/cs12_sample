﻿
/* ================= 예제 5.19: 열려 있는 파일 자원 ================= */

class Program
{
    static void Main(string[] args)
    {
        FileCreate();
        Console.WriteLine("파일이 열려 있습니다.");
        Console.ReadLine();
    }

    private static void FileCreate()
    {
        FileStream fs = new FileStream("output.log", FileMode.Create);

        // fs.Close();
        // fs.Dispose();
    }
}