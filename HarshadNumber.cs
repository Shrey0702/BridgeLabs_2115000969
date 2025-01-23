using System;

class HarshadNumber
{
    static void Main()
    {
        // Input: Get the integer from the user
        Console.WriteLine("Enter a number to check if it is a Harshad Number:");
        int number = int.Parse(Console.ReadLine());

        // Initialize the sum of digits to 0
        int sum = 0;
        int originalNumber = number;

        // Use a while loop to calculate the sum of digits
        while (number != 0)
        {
            // Find the last digit of the number
            int digit = number % 10;

            // Add the digit to the sum
            sum += digit;

            // Remove the last digit from the number
            number /= 10;
        }

        // Check if the original number is divisible by the sum of its digits
        if (originalNumber % sum == 0)
        {
            Console.WriteLine(originalNumber + " is a Harshad Number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not a Harshad Number.");
        }
    }
}
