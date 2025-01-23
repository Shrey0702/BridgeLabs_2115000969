using System;

class AbundantNumber
{
    static void Main()
    {
        // Input from user
        Console.WriteLine("Enter a number to check if it is an Abundant Number:");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        // find divisors of the number
        for (int i = 1; i < number; i++)
        {
            // Check if i is a divisor of number
            if (number % i == 0)
            {
                sum += i; 
            }
        }

        // Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            Console.WriteLine(number + " is an Abundant Number.");
        }
        else
        {
            Console.WriteLine(number + " is not an Abundant Number.");
        }
    }
}
