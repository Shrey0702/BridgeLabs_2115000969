using System;
using System.IO;
class ReadLine
{
    static void Main()
    {
        string filePath = "large_text.txt"; 

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

