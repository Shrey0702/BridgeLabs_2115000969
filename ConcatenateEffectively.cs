namespace ConsoleApp1;

using System;
using System.Text;
class ConcatenateEffectively{
    static void Main(string[] args){
        string x=" ";
        Console.WriteLine("Program to append to word:");
        StringBuilder sb= new StringBuilder(Console.ReadLine());
        while(x!="exit"){
            Console.WriteLine("Enter the Word to append(Write exit to exit): ");
            x=Console.ReadLine();
            if(x!="exit"){
                sb.Append(x);
                Console.WriteLine("Current String: "+sb);
            } 
        }
        Console.WriteLine("THE END.");   
    }

}


