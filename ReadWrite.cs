using System;
using System.IO;

class ReadWrite
{
    static void Main()
    {
        string sourceFilePath = "test.txt"; 
        string destinationFilePath = @"C:\Users\Shrey\Documents\test.txt"; 

        try
        {
            // Check if the source file exists
            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }

            // Open source file for reading
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {
                sourceStream.CopyTo(destinationStream);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while processing the file: " + ex.Message);
        }
    }
}

