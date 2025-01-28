using System;

class NumberCheckerAdvanced1{
    public static void Main(){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Method to find the count of digits
        int digitCount = FindDigitCount(number);
        Console.WriteLine("Number of digits: " + digitCount);

        // Method to store digits of the number in an array
        int[] digits = StoreDigits(number);

        // Method to find the sum of digits
        int sumOfDigits = FindSumOfDigits(digits);
        Console.WriteLine("Sum of digits: " + sumOfDigits);

        // Method to find the sum of squares of digits
        double sumOfSquares = FindSumOfSquares(digits);
        Console.WriteLine("Sum of squares of digits: " + sumOfSquares);

        // Method to check if the number is a Harshad number
        bool isHarshad = IsHarshadNumber(digits, sumOfDigits);
        Console.WriteLine("Is the number a Harshad number? " + (isHarshad ? "Yes" : "No"));

        // Method to find the frequency of each digit
        int[,] digitFrequencies = FindDigitFrequencies(digits);
        Console.WriteLine("Digit frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (digitFrequencies[i, 1] > 0) // Only print digits that appear
            {
                Console.WriteLine("Digit: " + digitFrequencies[i, 0] + " Frequency: " + digitFrequencies[i, 1]);
            }
        }
    }

    // Method to find the count of digits in the number
    public static int FindDigitCount(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

    // Method to store the digits of the number in an array
    public static int[] StoreDigits(int number)
    {
        int digitCount = FindDigitCount(number);
        int[] digits = new int[digitCount];
        for (int i = digitCount - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to find the sum of digits of the number
    public static int FindSumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to find the sum of squares of digits of the number
    public static double FindSumOfSquares(int[] digits)
    {
        double sum = 0;
        foreach (int digit in digits)
        {
            sum += Math.Pow(digit, 2);
        }
        return sum;
    }

    // Method to check if the number is a Harshad number
    public static bool IsHarshadNumber(int[] digits, int sumOfDigits)
    {
        int number = 0;
        foreach (int digit in digits)
        {
            number = number * 10 + digit;
        }
        return number % sumOfDigits == 0;
    }

    // Method to find the frequency of each digit in the number
    public static int[,] FindDigitFrequencies(int[] digits)
    {
        int[,] frequency = new int[10, 2]; // Array to store digit (column 0) and frequency (column 1)
        
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i; // First column holds digits from 0 to 9
            frequency[i, 1] = 0; // Initialize frequency count
        }

        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }
}
