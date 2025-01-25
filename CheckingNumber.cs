using System;

class CheckingNumber{
    public static void Main(){
        // declaring an array to store 5 integers
        int[] numArr = new int[5];

        // for loop to take user input for the array
        for (int i = 0; i < numArr.Length; i++){
            Console.Write("Enter number {0}: ", i + 1);
            numArr[i] = int.Parse(Console.ReadLine()); // Parse the input to an integer
        }

        // calling the method to check the numbers
        CheckingNegativePositiveZero(numArr);
    }

    // method to check if the number is positive/negative/zero or even/odd
    static void CheckingNegativePositiveZero(int[] numbers){
        foreach (int num in numbers){
            if (num > 0){
                if (num % 2 == 0){
                    Console.WriteLine("The number {0} is a positive even number", num);
                }
                else{
                    Console.WriteLine("The number {0} is a positive odd number", num);
                }
            }
            else if (num == 0){
                Console.WriteLine("The number {0} is zero", num);
            }
            else{
                Console.WriteLine("The number {0} is a negative number", num);
            }
        }

        // Check the first and last numbers in the array
        if (numbers[0] == numbers[numbers.Length - 1]){
            Console.WriteLine("The first number {0} is equal to the last number {1}", numbers[0], numbers[numbers.Length - 1]);
        }
        else if (numbers[0] > numbers[numbers.Length - 1]){
            Console.WriteLine("The first number {0} is greater than the last number {1}", numbers[0], numbers[numbers.Length - 1]);
        }
        else if (numbers[0] < numbers[numbers.Length - 1]){
            Console.WriteLine("The first number {0} is less than the last number {1}", numbers[0], numbers[numbers.Length - 1]);
        }
    }
}
