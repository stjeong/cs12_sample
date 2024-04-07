
/* ================= 17.7 패턴 매칭 개선(Pattern matching enhancements) ================= */

// Install-Package System.ValueTuple

var t = (args.Length, "# of Args");

if (t is (int, string)) { }

object objValue = args.Length;

switch (objValue)
{
    case int: break;
    case System.String: break;
}

// if (args.Length < 2)
if (args.Length is < 2)
{
    Console.WriteLine("# of args must be two at least.");
}

if (objValue is long and < 2L)
{
    Console.WriteLine("# of args must be two at least.");
}

Console.WriteLine("GreaterThan10(5): " + GreaterThan10(5));
static bool GreaterThan10(int number) =>
        number is > 10;

Console.WriteLine("IsGreaterThanTarget(15, 10): " + IsGreaterThanTarget(15, 10));
static bool IsGreaterThanTarget(int number, int target) =>
    number is int value && value > target;

/*
// 상수식만 올 수 있으므로 컴파일 오류
static bool GreaterThanTarget(int number, int target) =>
    number switch
    {
        > target => true,
        _ => false
    };
*/

Console.WriteLine("GreaterThanTarget(5, 10): " + GreaterThanTarget(5, 10));
static bool GreaterThanTarget(int number, int target) =>
    number switch
    {
        int value when value > target => true,
        // int when number > target => true,
        _ => false
    };

Console.WriteLine("IsLetter('c'): " + IsLetter('c'));
static bool IsLetter(char c) =>
    c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

Console.WriteLine("IsLetter2('c'): " + IsLetter2('c'));
static bool IsLetter2(char c) =>
    c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');

Console.WriteLine("IsLetter3('c'): " + IsLetter3('c'));
static bool IsLetter3(char c) => 
    (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');

Console.WriteLine("IsLetter4('c'): " + IsLetter4('c'));
static bool IsLetter4(char c) =>
    c switch
    {
        >= 'a' and <= 'z' or >= 'A' and <= 'Z' => true,
        _ => false
    };

if (!(objValue is null))
{
    Console.WriteLine("not null");
}

if (objValue is not null)
{
    Console.WriteLine("not null");
}
