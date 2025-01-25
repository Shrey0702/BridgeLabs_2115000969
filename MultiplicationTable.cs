using System;

class MultiplicationTable{
    public static void Main(){
        // enter the number for generating it's table
        Console.Write("Enter a number to generate its multiplication table: ");
        int number = int.Parse(Console.ReadLine()); // Read and parse the input

        // defining an array to store results from 1 to 10
        int[] multiplicationTable = new int[10];

        // calculating the table and storing it in an array
        for (int i = 0; i < multiplicationTable.Length; i++){
            multiplicationTable[i] = number * (i + 1); // Multiply the number with (i + 1)
			// used i + 1 because i starts from 0 which will give wrong  table
        }

        // displaying the multiplication table
        Console.WriteLine("Multiplication Table of {0}: ", number);
        for (int i = 0; i < multiplicationTable.Length; i++){
            Console.WriteLine("{0} * {1} = {2}", number, i + 1, multiplicationTable[i]);
        }
    }
}
