using System.Text;

namespace ConsoleApp1;

public class ReverseString
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string:   ");
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        sb.Append(input);
        for (int i = 0; i < sb.Length/ 2; i++)
        {
            char temp = sb[i];
           sb[i] = sb[sb.Length - 1 - i];
           sb[sb.Length - 1 - i] = temp;
           
        }
        Console.WriteLine(sb);
    }
}