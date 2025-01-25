using System;

class FactorsOfNumber{
    public static void Main(){
        // Taking user input
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize variables for factors array
        int maxFactor = 10; // Initializing size of the array
        int[] factors = new int[maxFactor]; // Creating the required array for factors
        int index = 0; // Index to track the position in the factors array

        // Loop to find the factors of the number
        for (int i = 1; i <= number; i++){
            if (number % i == 0) {   // Checking if i is a factor
                if (index == maxFactor){    // Resizing the array if needed
                    maxFactor *= 2; // Double the size of the array
                    int[] temp = new int[maxFactor]; // Temporary array with larger size

                    // Copying existing factors to the new array
                    for (int j = 0; j < factors.Length; j++){
                        temp[j] = factors[j];
                    }

                    factors = temp; // Assigning the temp array back to factors
                }

                factors[index] = i; // Adding the factor to the array
                index++; // Incrementing the index
            }
        }

        // Displaying the factors of the number
        Console.WriteLine("\nFactors of {0}:", number);
        for (int i = 0; i < index; i++){
            Console.Write(factors[i] + " ");
        }
    }
}
