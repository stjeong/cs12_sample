
/* ================= 16.10 문자열 @, $ 접두사 혼합 지원 ================= */

class Program
{
    static void Main(string[] args)
    {
        string path = @"c:\temp";

        // 컴파일 가능
        string filePath1 = $@"{path}\file.log";

        // C# 7.3 이전까지 컴파일 오류
        string filePath2 = @$"{path}\file.log";
    }
}
