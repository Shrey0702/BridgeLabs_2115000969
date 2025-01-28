using System;

class NumberCheckerAdvanced2{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Method to find the count of digits
        int digitCount = FindDigitCount(number);
        Console.WriteLine("Number of digits: " + digitCount);

        // Method to store digits of the number in an array
        int[] digits = StoreDigits(number);

        // Method to reverse the digits array
        int[] reversedDigits = ReverseDigits(digits);
        Console.WriteLine("Reversed digits: " + string.Join("", reversedDigits));

        // Method to compare the original and reversed arrays
        bool areArraysEqual = CompareArrays(digits, reversedDigits);
        Console.WriteLine("Are the digits the same when reversed? " + (areArraysEqual ? "Yes" : "No"));

        // Method to check if the number is a palindrome
        bool isPalindrome = IsPalindrome(digits);
        Console.WriteLine("Is the number a palindrome? " + (isPalindrome ? "Yes" : "No"));

        // Method to check if the number is a Duck number
        bool isDuck = IsDuckNumber(digits);
        Console.WriteLine("Is the number a Duck number? " + (isDuck ? "Yes" : "No"));
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

    // Method to reverse the digits array
    public static int[] ReverseDigits(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }

    // Method to compare two arrays and check if they are equal
    public static bool CompareArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }

        return true;
    }

    // Method to check if a number is a palindrome
    public static bool IsPalindrome(int[] digits)
    {
        int[] reversedDigits = ReverseDigits(digits);
        return CompareArrays(digits, reversedDigits);
    }

    // Method to check if a number is a Duck number
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit != 0)
            {
                return true;
            }
        }
        return false;
    }
}
