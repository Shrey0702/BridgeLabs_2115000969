using System;

class NumberCheckerAdvanced5{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Find factors of the number
        int[] factors = FindFactors(number);
        Console.WriteLine("Factors of the number: " + string.Join(", ", factors));

        // Find the greatest factor
        int greatestFactor = FindGreatestFactor(factors);
        Console.WriteLine("Greatest factor: " + greatestFactor);

        // Find the sum of the factors
        int sumOfFactors = FindSumOfFactors(factors);
        Console.WriteLine("Sum of factors: " + sumOfFactors);

        // Find the product of the factors
        int productOfFactors = FindProductOfFactors(factors);
        Console.WriteLine("Product of factors: " + productOfFactors);

        // Find the product of cube of the factors
        double productOfCubes = FindProductOfCubes(factors);
        Console.WriteLine("Product of cubes of factors: " + productOfCubes);

        // Check if the number is a perfect number
        bool isPerfect = IsPerfectNumber(number);
        Console.WriteLine("Is the number perfect? " + (isPerfect ? "Yes" : "No"));

        // Check if the number is an abundant number
        bool isAbundant = IsAbundantNumber(number);
        Console.WriteLine("Is the number abundant? " + (isAbundant ? "Yes" : "No"));

        // Check if the number is a deficient number
        bool isDeficient = IsDeficientNumber(number);
        Console.WriteLine("Is the number deficient? " + (isDeficient ? "Yes" : "No"));

        // Check if the number is a strong number
        bool isStrong = IsStrongNumber(number);
        Console.WriteLine("Is the number strong? " + (isStrong ? "Yes" : "No"));
    }

    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // Counting the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        // Storing the factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    // Method to find the greatest factor of a number using the factors array
    public static int FindGreatestFactor(int[] factors)
    {
        int greatest = Int32.MinValue;
        foreach (int factor in factors)
        {
            if (factor > greatest)
            {
                greatest = factor;
            }
        }
        return greatest;
    }

    // Method to find the sum of the factors using the factors array
    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors using the factors array
    public static int FindProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cube of the factors using the factors array
    public static double FindProductOfCubes(int[] factors)
    {
        double productOfCubes = 1;
        foreach (int factor in factors)
        {
            productOfCubes *= Math.Pow(factor, 3);
        }
        return productOfCubes;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int sumOfProperDivisors = 0;

        // Finding the sum of proper divisors (divisors excluding the number itself)
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sumOfProperDivisors += i;
            }
        }

        // A perfect number is equal to the sum of its proper divisors
        return sumOfProperDivisors == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int sumOfProperDivisors = 0;

        // Finding the sum of proper divisors (divisors excluding the number itself)
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sumOfProperDivisors += i;
            }
        }

        // An abundant number is one where the sum of its proper divisors is greater than the number itself
        return sumOfProperDivisors > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int sumOfProperDivisors = 0;

        // Finding the sum of proper divisors (divisors excluding the number itself)
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sumOfProperDivisors += i;
            }
        }

        // A deficient number is one where the sum of its proper divisors is less than the number itself
        return sumOfProperDivisors < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int originalNumber = number;
        int sumOfFactorials = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sumOfFactorials += Factorial(digit);
            number /= 10;
        }

        // A strong number is one where the sum of the factorials of its digits is equal to the number itself
        return sumOfFactorials == originalNumber;
    }

    // Helper method to calculate factorial
    public static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
