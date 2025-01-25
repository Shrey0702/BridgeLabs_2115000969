using System;

class LargestAndSecondLargest{
    public static void Main(){
        // taking user input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // initializing the array to store the digits
        int maxDigit = 10; // maximum size of the array
        int[] digits = new int[maxDigit]; // array to store digits
        int index = 0; // index to track the position in the array
		// below code will check if index goes out of limit or 
        while (number != 0 && index < maxDigit){  
            digits[index] = number % 10; // getting the last digit
            number /= 10; // removing the last digit from the number
            index++; // incrementing the index
        }

        // variables to store the largest and second largest digits
        int largest = -1;
        int secondLargest = -1;

        // looping through the array to find the largest and second largest
        for (int i = 0; i < index; i++){
            if (digits[i] > largest){
                secondLargest = largest; // updating second largest
                largest = digits[i]; // updating largest
            }
			
			// below condition will check if the given number is only greater than second largest
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i]; // Update second largest
            }
        }

        // displaying the results
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}
