using System.Text;

namespace ConsoleApp1;

public class RemovingDuplicates
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder(input);
        for (int i = 0; i < sb.Length; i++)
        {
            for (int j = i + 1; j < sb.Length; j++)
            {
                if (sb[i] == sb[j])
                {
                    sb.Remove(j, 1);
                    j--;  // really important step to run my code without bugsss

                }
            }

            
        }
        Console.WriteLine(sb.ToString());
    }
}