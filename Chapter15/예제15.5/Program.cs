
/* ================= 15.5 자동 구현 속성의 특성 지원 ================= */

[Serializable]
public class Foo
{
    [field: NonSerialized]
    public string MySecret { get; set; }
}


/*
[Serializable]
public class Foo
{
    [NonSerialized]
    string _mySecret;

    public string MySecret
    {
        get { return _mySecret; }
        set { _mySecret = value; }
    }
}
*/

class Program
{
    static void Main(string[] args)
    {
    }
}
