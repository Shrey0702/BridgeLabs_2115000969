using System;
using System.IO;
using System.Text;

class UpperToLower
{
    static void Main()
    {
        string sourceFilePath = "test.txt";
        string destinationFilePath = @"C:\Users\Vishu\Documents\test.txt";

        try
        {
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedSource = new BufferedStream(sourceStream))
            using (StreamReader reader = new StreamReader(bufferedSource, Encoding.UTF8))
            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedDestination = new BufferedStream(destinationStream))
            using (StreamWriter writer = new StreamWriter(bufferedDestination, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("File processed and saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

