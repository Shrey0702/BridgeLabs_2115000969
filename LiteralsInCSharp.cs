using System;
    class LiteralsInCSharp
    {
        static void Main(string[] args)
        {
			//Charachter literals
            //Character literal using single quote
            char ch1 = 'S';
            Console.WriteLine("Single Quote: " + ch1);

            //Character literal using Unicode representation
            char ch2 = '\u0041';  
            Console.WriteLine("Unicode: " + ch2);

            //Character literal using Escape character
            Console.WriteLine("Escape: Hello\nShrey\tBhardwaj!! :D");
			
			//String Literals
			string str1 = "BridgeLabz";
            string str2 = @"BridgeLabz";
            string str3 = "Bridge\tLabz";
            string str4 = @"Bridge\nLabz";
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);
            Console.WriteLine("str3: " + str3);
            Console.WriteLine("str4: " + str4);
            Console.ReadKey();
        }
    }