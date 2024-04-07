
/* ================= 예제 6.58: private 속성 접근 ================= */

using System.Reflection;

namespace ConsoleApp1;

public class SystemInfo
{
    bool _is64Bit;

    public SystemInfo()
    {
        _is64Bit = Environment.Is64BitOperatingSystem;
        Console.WriteLine("SystemInfo created.");
    }

    public void WriteInfo()
    {
        Console.WriteLine("OS == {0}bits", (_is64Bit == true) ? "64" : "32");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Type systemInfoType = Type.GetType("ConsoleApp1.SystemInfo");
        //object objInstnce = Activator.CreateInstance(systemInfoType);

        Type systemInfoType = Type.GetType("ConsoleApp1.SystemInfo");
        ConstructorInfo ctorInfo = systemInfoType.GetConstructor(Type.EmptyTypes);
        object objInstance = ctorInfo.Invoke(null);

        FieldInfo fieldInfo = systemInfoType.GetField("_is64Bit", BindingFlags.NonPublic | BindingFlags.Instance);
        
        // 기존 값을 구하고,
        object oldValue = fieldInfo.GetValue(objInstance);
        
        // 새로운 값을 쓴다.
        fieldInfo.SetValue(objInstance, !Environment.Is64BitOperatingSystem);

        MethodInfo methodInfo = systemInfoType.GetMethod("WriteInfo");
        methodInfo.Invoke(objInstance, null);
    }
}
