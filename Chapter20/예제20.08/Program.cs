using System.Diagnostics.CodeAnalysis;

#pragma warning disable MYID01

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            MyFeature pg = new (); // error MYID01: 'MyType'은(는) 평가 목적으로 제공되며, 이후 업데이트에서 변경되거나 제거될 수 있습니다. 계속하려면 이 진단을 표시하지 않습니다.
            pg.ToString();
        }
    }
}

[Experimental("MYID01")]
public class MyFeature
{
}
