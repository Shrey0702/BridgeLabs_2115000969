using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipedStreams
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.GetClientHandleAsString()))
        {
            Thread writerThread = new Thread(() => WriteToPipe(pipeServer));
            Thread readerThread = new Thread(() => ReadFromPipe(pipeClient));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteToPipe(PipeStream pipe)
    {
        using (StreamWriter writer = new StreamWriter(pipe))
        {
            writer.AutoFlush = true;
            for (int i = 1; i <= 5; i++)
            {
                writer.WriteLine($"Message {i}");
                Thread.Sleep(500);
            }
        }
    }

    static void ReadFromPipe(PipeStream pipe)
    {
        using (StreamReader reader = new StreamReader(pipe))
        {
            string message;
            while ((message = reader.ReadLine()) != null)
            {
                Console.WriteLine("Received: " + message);
            }
        }
    }
}

