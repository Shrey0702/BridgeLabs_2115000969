using System;
using System.IO;
class PrimitiveData
{
    static void Main()
    {
        string filePath = "students.dat";

        // Writing student details to a binary file
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fileStream))
        {
            writer.Write(1); 
            writer.Write("Shyam Singh"); 
            writer.Write(3.8); 

            writer.Write(2);
            writer.Write("Rick Chauhan");
            writer.Write(3.9);
        }

        Console.WriteLine("Student details saved successfully.");

        // Reading student details from the binary file
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fileStream))
        {
            while (fileStream.Position < fileStream.Length)
            {
                int rollNumber = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();
                Console.WriteLine($"Roll Number: {rollNumber}, Name: {name}, GPA: {gpa}");
            }
        }
    }
}

