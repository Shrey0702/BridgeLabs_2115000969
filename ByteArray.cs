using System;
using System.IO;

class ByteArray
{
    static void Main()
    {
        string sourceImagePath = "picture1.jpg"; 
        string destinationImagePath = @"C:\Users\Vishu\Documents\picture1.jpg"; 

        try
        {
            byte[] imageBytes = File.ReadAllBytes(sourceImagePath);

            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
            {
                File.WriteAllBytes(destinationImagePath, memoryStream.ToArray());
            }

            Console.WriteLine("Image copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

