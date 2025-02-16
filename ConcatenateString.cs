using System.Text;

namespace ConsoleApp1;

public class ConcatenateString
{
    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        Console.WriteLine("Enter the string to concatenate: ");
        Console.WriteLine("type : \"exit\" to stop concatenation: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }
            sb.Append(input);
        }
        
        Console.WriteLine(sb.ToString());
    }
}