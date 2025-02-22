unbuffered streams.
using System;
using System.Diagnostics;
using System.IO;

class FileCopy
{
    static void Main()
    {
        string sourceFilePath = "large_file.dat"; 
        string destinationFilePathBuffered = "destination_buffered.dat";
        string destinationFilePathUnbuffered = "destination_unbuffered.dat";

        long bufferedTime = CopyFileUsingBufferedStream(sourceFilePath, destinationFilePathBuffered);
        long unbufferedTime = CopyFileUsingFileStream(sourceFilePath, destinationFilePathUnbuffered);

        Console.WriteLine($"Buffered Stream Copy Time: {bufferedTime} ms");
        Console.WriteLine($"Unbuffered Stream Copy Time: {unbufferedTime} ms");
    }

    static long CopyFileUsingBufferedStream(string source, string destination)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream destinationStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedSource = new BufferedStream(sourceStream, 4096))
        using (BufferedStream bufferedDestination = new BufferedStream(destinationStream, 4096))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = bufferedSource.Read(buffer, 0, buffer.Length)) > 0)
            {
                bufferedDestination.Write(buffer, 0, bytesRead);
            }
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    static long CopyFileUsingFileStream(string source, string destination)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream destinationStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                destinationStream.Write(buffer, 0, bytesRead);
            }
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
}

