
/* ================= 예제 5.6: NAudio 패키지를 이용한 mp3 재생 ================= */

using NAudio.Wave;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        string mp3Path = @"C:\temp\Suddenly.mp3";

        AudioFileReader audioFile = new AudioFileReader(mp3Path);
        WaveOutEvent outputDevice = new WaveOutEvent();

        outputDevice.Init(audioFile);
        outputDevice.Play();
        while (outputDevice.PlaybackState == PlaybackState.Playing)
        {
            Thread.Sleep(1000);
        }
    }
}
