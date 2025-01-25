using System;

class MultiplicationTableForRange{
    public static void Main(){
		// taking input from user
        Console.Write("Enter a number between 6 and 9 to generate it's table: ");
        int number = int.Parse(Console.ReadLine()); // Read and parse the input

		// checking if the number lies in the range of 6 to 9 or not
        if (number < 6 || number > 9){
            Console.WriteLine("Please enter a valid number between 6 and 9.");
            return; // exiting if the number is outside the valid range
        }

        // defining an array to store multiplication results from 1 to 10
        int[] multiplicationResult = new int[10];

        // finding the multiplication table of the number from 1 to 10 and store it in the array
        for (int i = 0; i < multiplicationResult.Length; i++){
            multiplicationResult[i] = number * (i + 1); // Multiply the number with (i + 1)
        }

        // displaying the multiplication table of the number
        Console.WriteLine("Multiplication Table of {0}:", number);
        for (int i = 0; i < multiplicationResult.Length; i++){
            Console.WriteLine("{0} * {1} = {2}", number, i + 1, multiplicationResult[i]);
        }
    }
}
