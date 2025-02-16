using System.Transactions;

namespace ConsoleApp1;

public class ReadLineByLine
{
    public static void Main(string[] args)
    {
        string path =
            @"C:\Users\Shrey\OneDrive\Desktop\CAPEGEMINI training BRIDGE LABS\practice and assignments\Assignment 15-02-2025\ConsoleApp1\trying.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    
    
}