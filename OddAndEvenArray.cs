using System;

class OddAndEvenArray{
    public static void Main(){
        // taking user input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        // checking if the number is a natural number
        if (number <= 0){
            Console.Error.WriteLine("Please enter a valid natural number.");
			Environment.Exit(0);
        }

        // creating arrays to store odd and even numbers
        int[] oddNumbers = new int[number / 2 + 1]; // array size for odd numbers
        int[] evenNumbers = new int[number / 2 + 1]; // array size for even numbers

        // initialising index variables for odd and even numbers
        int oddIndex = 0, evenIndex = 0;

        // using for loop to iterate through the numbers
        for (int i = 1; i <= number; i++){
            if (i % 2 == 0){
                evenNumbers[evenIndex] = i;
                evenIndex++; // updating the index to point to next location
            }
            else{  // if will run if the number is odd
                oddNumbers[oddIndex] = i;
                oddIndex++; // updating the index to point to next location
            }
        }

        // displaying odd array
		Console.WriteLine();
        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddIndex; i++){
            Console.Write(oddNumbers[i] + " ");
        }

        // printing even array
		Console.WriteLine();
        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenIndex; i++){
            Console.Write(evenNumbers[i] + " ");
        }
    }
}
