using System;

class NumberChecker{
    public static void Main(){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int digitCount = FindDigitCount(number);
        Console.WriteLine("number of digits: " + digitCount);

        // method to store digits of the number in an array
        int[] digits = StoreDigits(number);

        // method to check if the number is a Duck number
        bool isDuck = IsDuckNumber(digits);
        Console.WriteLine("is the number a Duck number? " + (isDuck ? "Yes" : "No"));

        // method to check if the number is an Armstrong number
        bool isArmstrong = IsArmstrongNumber(digits, digitCount);
        Console.WriteLine("is the number an Armstrong number? " + (isArmstrong ? "Yes" : "No"));

        // method to find the largest and second largest digits
        int[] largestDigits = FindLargestAndSecondLargest(digits);
        Console.WriteLine("largest digit: " + largestDigits[0]);
        Console.WriteLine("second largest digit: " + largestDigits[1]);

        // method to find the smallest and second smallest digits
        int[] smallestDigits = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("smallest digit: " + smallestDigits[0]);
        Console.WriteLine("second smallest digit: " + smallestDigits[1]);
    }

    // Method to find the count of digits in the number
    public static int FindDigitCount(int number){
        int count = 0;
        while (number != 0){
            number /= 10;
            count++;
        }
        return count;
    }

    // method to store the digits of the number in an array
    public static int[] StoreDigits(int number){
        int digitCount = FindDigitCount(number);
        int[] digits = new int[digitCount];
        for (int i = digitCount - 1; i >= 0; i--){
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to check if the number is a Duck number
    public static bool IsDuckNumber(int[] digits){
        foreach (int digit in digits){
            if (digit != 0){
                return true;
            }
        }
        return false;
    }

    // Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int[] digits, int digitCount){
        int sum = 0;
        foreach (int digit in digits){
            sum += (int)Math.Pow(digit, digitCount);
        }
        return sum == digits[0];
    }

    // Method to find the largest and second largest digits
    public static int[] FindLargestAndSecondLargest(int[] digits){
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int digit in digits){
            if (digit > largest){
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest){
                secondLargest = digit;
            }
        }

        return new int[] { largest, secondLargest };
    }

    // Method to find the smallest and second smallest digits
    public static int[] FindSmallestAndSecondSmallest(int[] digits){
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        foreach (int digit in digits){
            if (digit < smallest){
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest){
                secondSmallest = digit;
            }
        }

        return new int[] { smallest, secondSmallest };
    }
}
