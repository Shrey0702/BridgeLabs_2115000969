using System;

class NumberCheckerAdvanced3{
    public static void Main(){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is prime
        bool isPrime = IsPrime(number);
        Console.WriteLine("Is the number prime? " + (isPrime ? "Yes" : "No"));

        // Check if the number is neon
        bool isNeon = IsNeon(number);
        Console.WriteLine("Is the number neon? " + (isNeon ? "Yes" : "No"));

        // Check if the number is spy
        bool isSpy = IsSpy(number);
        Console.WriteLine("Is the number spy? " + (isSpy ? "Yes" : "No"));

        // Check if the number is automorphic
        bool isAutomorphic = IsAutomorphic(number);
        Console.WriteLine("Is the number automorphic? " + (isAutomorphic ? "Yes" : "No"));

        // Check if the number is buzz
        bool isBuzz = IsBuzz(number);
        Console.WriteLine("Is the number buzz? " + (isBuzz ? "Yes" : "No"));
    }

    // Method to check if a number is prime
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    // Method to check if a number is neon
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;

        // Sum the digits of the square
        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }

        return sumOfDigits == number;
    }

    // Method to check if a number is spy
    public static bool IsSpy(int number)
    {
        int sum = 0, product = 1;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }

    // Method to check if a number is automorphic
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        while (square > 0)
        {
            if (square % 10 != number % 10)
            {
                return false;
            }
            square /= 10;
            number /= 10;
        }
        return true;
    }

    // Method to check if a number is buzz
    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }
}
