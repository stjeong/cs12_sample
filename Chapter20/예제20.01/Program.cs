
/* ================= 20.1 기본 람다 매개 변수 ================= */

using System.Reflection;

{
    var addWithDefault = (int addTo = 2) => addTo + 1;
    int result = addWithDefault();  // result == 3
    Console.WriteLine(result);

    result = addWithDefault(5); // result ==  6
    Console.WriteLine(result);
}

{
    Func<int, int> addWithDefault = (int addTo) => addTo + 1;
}

{
#pragma warning disable CS9099 // The default parameter value does not match in the target delegate type.
    // 컴파일 경고 CS9099
    Func<int, int> addWithDefault = (int addTo = 2) => addTo + 1;
#pragma warning restore CS9099 // The default parameter value does not match in the target delegate type.

    // 컴파일 오류
    // addWithDefault();
}

Type tDelegate = typeof(MyFunc);
MethodInfo? invoke = tDelegate.GetMethod("Invoke");
if (invoke == null)
{
    return;
}

ParameterInfo[] parameters = invoke.GetParameters();
for (int i = 0; i < parameters.Length; i++)
{
    Console.WriteLine($"default value: {parameters[i].Name} == {parameters[i].DefaultValue}");
}

public delegate int MyFunc(int x = 1, int y = 5);