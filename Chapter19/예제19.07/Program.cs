
using System.Linq;

int[] arr1 = { 1, 3, 2, 4 };
int[] arr2 = { 1, 3, 6, 7 };
int[] arr3 = { 1, 2, 3, 1, 4 };

if (arr1 is [1, ..])
{
    Console.WriteLine(string.Join(',', arr1)); // 1,3,2,4
}

if (arr2 is [1, 3, ..])
{
    Console.WriteLine(string.Join(',', arr2)); // 1,3,6,7
}

if (arr3 is [1, .., 3, _, 4])
{
    Console.WriteLine(string.Join(',', arr3)); // 1,2,3,1,4
}

Console.WriteLine(Start1And3orHigher(arr3));
Console.WriteLine(EndWith4or5(arr1));

static int Start1And3orHigher(int[] values)
{
    const int condition = 3;

    switch (values)
    {
        case [1, 2, >= condition, ..]: return 1;
        default: return 0;
    };
}

static int EndWith4or5(int[] values) => values switch
    {
        [.., 4 or 5] => 1,
        _ => 0,
    };


ReadOnlySpan<char> str = "TEST".AsSpan()[0..2];
if (str == "TE")
{
    Console.WriteLine(" == TE");
}

Span<int> oneToFour = stackalloc int[] { 1, 2, 3, 4 };

if (oneToFour is [1, .. var remains, 4])
{
    Console.WriteLine(string.Join(',', remains.ToArray()));
}

Console.WriteLine();

NaturalNumber list = new NaturalNumber();
if (list is [1, .., Int32.MaxValue])
{
    Console.WriteLine("integer 범위");
}

ReadOnlySpan<char> text = "TEST".AsSpan()[0..2];

if (text is ['T', 'E'])
{
    Console.WriteLine("['T', 'E'] Equals");
}

if (text is "TE")
{
    Console.WriteLine(""" "TE" Equals""");
}

switch (text)
{
    case "TE":
        Console.WriteLine(""" "TE" Equals""");
        break;
    case "TA":
        break;
}

public class NaturalNumber
{
    int _length = Int32.MaxValue;

    public int this[int index]
    {
        get { return index + 1; }
    }

    public int Length => _length;

    // 또는,
    // public int Count => _length;
}
