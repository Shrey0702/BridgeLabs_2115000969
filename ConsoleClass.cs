// learning ABOUT CONSOLE CLASS IN C#
using System;
namespace MyFirstProject
{
    internal class ConsoleClass
    {
        static void Main(string[] args)
        {
			//properties and methods used to manipulate the onsole UI
			Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Understanding Console Class";
            Console.WriteLine("BackgroundColor: Blue");
            Console.WriteLine("ForegroundColor: White");
            Console.WriteLine("Title: Understanding Console Class");
            //We can access WriteLine and Write method using class name
            //as these methods are static

            Console.WriteLine("Hello");
            Console.Write("HI ");
            Console.Write("Bye ");
            Console.WriteLine("Welcome");
            Console.Write("C#.NET ");
			
			// used to print variable using concole
			string name = "Shrey!!";
            Console.WriteLine(name);
            Console.WriteLine("Hello " + name);
		//	Console.write($"hello my name is {name}"); not working on my version
		
			// used to read a signle charachter from console
            Console.ReadKey();
			
			
			//SHOWING OUTPUT USING CONSOLE CLASS
        }
    }
}