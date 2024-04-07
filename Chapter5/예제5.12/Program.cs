
/* ================= 예제 5.11: IndexOutOfRangeException 예외가 발생하는 코드 ================= */

class Program
{
    static void Main(string[] args)
    {
        int[] intArray = new int[10];

        int lastElem = intArray[11];
    }
}