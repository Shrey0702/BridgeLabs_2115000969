using System;
using System.IO;
class UserInput
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string age = Console.ReadLine();

        Console.Write("Enter your favorite programming language: ");
        string language = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter("user_info.txt"))
        {
            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Programming Language: " + language);
        }

        Console.WriteLine("User information saved successfully.");
    }
}

