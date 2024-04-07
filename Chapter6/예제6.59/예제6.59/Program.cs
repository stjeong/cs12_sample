
/* ================= 예제 6.59: 어셈블리를 참조하지 않고 다른 DLL의 클래스를 사용 ================= */

using System.Reflection;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string dllPath = GetClassLibaryPath();

        Assembly asm = Assembly.LoadFrom(dllPath);

        Type systemInfoType = asm.GetType("ClassLibrary1.SystemInfo");

        ConstructorInfo ctorInfo = systemInfoType.GetConstructor(Type.EmptyTypes);
        object objInstance = ctorInfo.Invoke(null);

        MethodInfo methodInfo = systemInfoType.GetMethod("WriteInfo");
        methodInfo.Invoke(objInstance, null);

        FieldInfo fieldInfo = systemInfoType.GetField("_is64Bit", BindingFlags.NonPublic | BindingFlags.Instance);
        object oldValue = fieldInfo.GetValue(objInstance);

        fieldInfo.SetValue(objInstance, !Environment.Is64BitOperatingSystem);
        methodInfo.Invoke(objInstance, null);
    }

    private static string GetClassLibaryPath()
    {
        string path = Path.GetDirectoryName(typeof(Program).Assembly.Location);
        string libPath = Path.Combine(path, "..", "..", "..", "..", "ClassLibrary1", "bin", "Debug", "net7.0", "ClassLibrary1.dll");

        return libPath;
    }
}


