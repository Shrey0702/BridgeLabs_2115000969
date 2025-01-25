using System;

class ReverseNumberUsingArrays{
    public static void Main(){
        // taking user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // checking if the number is 0
        if (number == 0){
            Console.WriteLine("Reversed number: 0");
            return;
        }

        // finding the count of digits in the number
        int tempNumber = number;
        int digitCount = 0;
        // until we reach the last digit
        while (tempNumber != 0){
            tempNumber /= 10; // removing the last digit
            digitCount++; // incrementing the digit count
        }

        // creating an array to store the digits
        int[] digits = new int[digitCount]; // we used digitCount to create digits array
        tempNumber = number; // resetting tempNumber to number again

        // storing the digits in the array
        int index = 0;
        while (tempNumber != 0){
            digits[index] = tempNumber % 10; // storing the last digit in the array
            tempNumber /= 10; // removing the last digit
            index++; // incrementing the index
        }

        // displaying the digits in reverse order
        Console.Write("Reversed number: ");
        foreach (int digit in digits){
            Console.Write(digit); //  printing reversed array
        }
    }
}
