using System;

class LargestAndSecondLargestChangeSize{
    public static void Main(){
        // taking user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // initialising the array to store the digits
        int maxDigit = 10; // maximum size of the array initially
        int[] digits = new int[maxDigit]; // array to store digits
        int index = 0; // index to track the position in the array

        while (number != 0){
            // if the array is full increase its size
            if (index == maxDigit){
                maxDigit += 10; // increase the max size by 10
                int[] temp = new int[maxDigit]; // creating a new array with the increased size

                // copying elements from the old array to the new array
                for (int i = 0; i < digits.Length; i++){
                    temp[i] = digits[i];
                }

                digits = temp; // copying the new array to digits
            }

            // getting the last digit and add it to the array
            digits[index] = number % 10; 
            number /= 10; // removing the last digit from the number
            index++; // incrementing the index
        }

        int largest = -1;
        int secondLargest = -1;

        // looping through the array to find the largest and second largest
        for (int i = 0; i < index; i++){
            if (digits[i] > largest){
                secondLargest = largest; // Update second largest
                largest = digits[i]; // Update largest
            }
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i]; // Update second largest
            }
        }

        // displaying the results
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}
