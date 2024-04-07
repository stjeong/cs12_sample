
/* ================= 예제 4.11 배열 요소에서의 암시적 형 변환 ================= */

public class Computer
{
    bool powerOn;
    public void Boot()
    {
        powerOn = true;
        Console.WriteLine("Boot - " + powerOn);
    }

    public void Shutdown() { powerOn = false; }
    public void Reset() { }
}

public class Notebook : Computer
{
    bool fingerScan; // Notebook 타입에 해당하는 멤버만 추가
    public bool HasFingerScanDevice() { return fingerScan; }

    public Notebook()
    {
        fingerScan = true;
    }
}

public class Desktop : Computer
{
}

public class Netbook : Computer
{
}

public class DeviceManager
{
    public void TurnOff(Computer device)
    {
        device.Shutdown();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 암시적 형변환
        Computer[] machines = new Computer[] { new Notebook(), new Desktop(), new Netbook() };

        DeviceManager manager = new DeviceManager();
        foreach (Computer device in machines)
        {
            manager.TurnOff(device);
        }
    }
}
