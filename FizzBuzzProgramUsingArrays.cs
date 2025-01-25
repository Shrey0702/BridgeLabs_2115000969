using System;

class FizzBuzzProgramUsingArrays{
    public static void Main(){
		// taking user input
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // checking if the number is a positive integer
        if (number <= 0){
            Console.WriteLine("enter a positive integer.");
            Environment.Exit(0);
        }

        // creating a string array to store the results
        string[] results = new string[number + 1];

        // loop from 0 to the number to add numbers to the array
        for (int i = 0; i <= number; i++){
			// adding special case for zero otherwise we will get fizzbuzz for zeor if not handled
            if (i == 0){
                results[i] = "0";
            }
			// cheking for both conditions to be true
            else if (i % 3 == 0 && i % 5 == 0){
                results[i] = "FizzBuzz";
            }
			// checking if multiple of 3
            else if (i % 3 == 0){
                results[i] = "Fizz";
            }
			// checking if numtiple of 5
            else if (i % 5 == 0){
                results[i] = "Buzz";
            }
			// it will print the numbers for all other cases
            else{
                results[i] = i.ToString();
            }
        }

        // loop through the array to display the results
        Console.WriteLine("\nFizzBuzz Results:");
        for (int i = 0; i < results.Length; i++){
            Console.WriteLine("Position {0} = {1}", i, results[i]);
        }
    }
}
