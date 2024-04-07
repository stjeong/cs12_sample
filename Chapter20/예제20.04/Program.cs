
/* ================= 20.4 인라인 배열 ================= */

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace 예제20._04;

// unsafe 문맥을 필요: AllowUnsafeBlocks 속성을 true로 설정
//unsafe struct StructType
//{
//    public int Count;
//    public fixed int fields[5]; // sizeof(int) * 5 크기만큼의 연속된 공간을 할당
//}

[System.Runtime.CompilerServices.InlineArray(5)]
public struct FieldBuffer
{
    private int _element0; // public 접근을 허용하지만 실용적이지 않음
                           // 필드는 단 한 개만 정의할 수 있음
}

public struct SafeStructType
{
    public int Count;
    public FieldBuffer Fields; // sizeof(int) * 5 크기만큼의 연속된 공간을 할당
}

[System.Runtime.CompilerServices.InlineArray(260)]
public struct MaxPath
{
    private char _element0;
}

[System.Runtime.CompilerServices.InlineArray(80)]
public struct TypeName
{
    private char _element0;
}

public struct SHFILEINFOW
{
    public IntPtr hIcon;
    public int iIcon;
    public int dwAttributes;
    public MaxPath szDisplayName;
    public TypeName szTypeName;
}

internal class Program
{
    [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
    public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFOW psfi, int cbFileInfo, uint uFlags);

    public const uint SHGFI_DISPLAYNAME = 0x000000200;
    public const uint SHGFI_TYPENAME = 0x000000400;

    static void Main(string[] args)
    {
        {
            SHFILEINFOW instance = new SHFILEINFOW();
            SHGetFileInfo(@"C:\Windows\System32\cmd.exe", 0, ref instance, Marshal.SizeOf(instance),
                SHGFI_DISPLAYNAME | SHGFI_TYPENAME);

            string text = new string(instance.szDisplayName);
            Console.WriteLine(text);
        }

        {
            SafeStructType inst = new SafeStructType();
            inst.Count = 5;
            for (int i = 0; i < 5; i++)
            {
                inst.Fields[i] = i; // indexer 구문으로 개별 요소 접근
                Console.WriteLine(inst.Fields[i]);
            }

            Span<int> elems = inst.Fields;
            foreach (int elem in elems)
            {
                Console.Write($"{elem},");
            }
        }

        {
            FieldBuffer buffer = new FieldBuffer();
            buffer[0] = 50;

            //fixed int buffer[50];
            //buffer[0] = 50;

            unsafe
            {
                int* ptr = stackalloc int[50];
                ptr[0] = 50;
            }
        }
    }
}

