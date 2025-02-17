namespace ConsoleApp1;

using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class StreamPerformance
{
    static void Main()
    {
        string filePath = "AdventuresOfTintin.txt"; 

        Console.WriteLine("Starting Large File Reading Test...");

        // using stream reader to read line by line
        Stopwatch sw = new Stopwatch();
        sw.Start();
        using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
        {
            while (sr.Read() != -1) { } 
        }
        sw.Stop();
        Console.WriteLine($"StreamReader Time: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        // using filestream to read bytes
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096]; 
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        sw.Stop();
        Console.WriteLine($"FileStream Time: {sw.ElapsedMilliseconds} ms");

    }
}
