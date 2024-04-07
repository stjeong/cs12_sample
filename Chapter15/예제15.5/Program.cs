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
