using System;

class StoreNumbersAndCalculateSum{
    public static void Main(){
        // creating an array to store up to 10 double values
        double[] numbers = new double[10];
        double total = 0.0; // variable to store the sum of all numbers
        int index = 0; // index to keep track of the position in the array

        // using infinit while loop
        while (true){
            // taking input from user
            Console.Write("Enter a number: ");
            double input = double.Parse(Console.ReadLine());
				
			// checking for the required edge cases - negative/zero or numbers >= 10
            if (input <= 0 || index >= numbers.Length){
                break; // exiting from infinit while loop
            }

            // storing the number in the array and incrementing the index if it not an exception
            numbers[index] = input;
            index++;
        }

        // calculating the sum of the numbers in the array
        for (int i = 0; i < index; i++){
            total += numbers[i]; 
        }

        // displaying all the numbers
        Console.WriteLine("\nEntered Numbers:");
        for (int i = 0; i < index; i++){
            Console.WriteLine(numbers[i]);
        }

        // displaying total sum
        Console.WriteLine("Total Sum: {0}", total);
    }
}
