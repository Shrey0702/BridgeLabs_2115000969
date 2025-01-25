using System;

class DigitFrequencyCounter {
    public static void Main() {
        // taking input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

		// finding total number of digit in the number
        int tempNumber = number;
        int digitCount = 0;
        while (tempNumber != 0) {
            tempNumber /= 10; // Removing the last digit
            digitCount++; // Incrementing the digit count
        }

        // creating an array to store the digits
        int[] digits = new int[digitCount];
        tempNumber = number; // Resetting tempNumber to the original number

        // storing the digits in the array
        int index = 0;
        while (tempNumber != 0) {
            digits[index] = tempNumber % 10; // storing the last digit in the array
            tempNumber /= 10; // Removing the last digit
            index++; // incrementing the index
        }

        // creating a frequency array which will update the position by + 1
        int[] frequency = new int[10];

        // Loop through the digits array and update the frequency
        for (int i = 0; i < digitCount; i++) {
		// it will add the number at the position digits[i]
            frequency[digits[i]]++; // Increment the count of the digit
        }

        // displaying the frequency of each digit
        Console.WriteLine("Digit frequencies in the number {0}:", number);
        for (int i = 0; i < 10; i++) {
            if (frequency[i] > 0) {
                Console.WriteLine("Digit {0}: {1} times", i, frequency[i]);
            }
        }
    }
}
