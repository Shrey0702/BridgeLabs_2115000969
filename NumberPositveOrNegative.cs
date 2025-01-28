using System;

public class NumberPositveOrNegative{
    // checking positive or not
    public static bool IsPositive(int number){
        if(number >= 0){
			return true;
		}
		return false;
    }

   
    public static bool IsEven(int number){
        if(number % 2 == 0){
			return true;
		}
		return false;
    }

    
    public static int Compare(int number1, int number2){
        if (number1 > number2){
            return 1;
        }
        else if (number1 == number2){
            return 0;
        }
        else{
            return -1;
        }
    }

    
    public static void Main(){
        int[] numbers = new int[5];

        // taking user input
        for (int i = 0; i < 5; i++){
            Console.Write("number {0}: ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }


        for (int i = 0; i < numbers.Length; i++){

            if (IsPositive(numbers[i])){
				// calling the method inside if statement
                if (IsEven(numbers[i]) == true){
                    Console.WriteLine("number {0} is positive and even", numbers[i]);
                }
                else{
					Console.WriteLine("number {0} is positive and odd", numbers[i]);
                }
            }
            else{
                Console.WriteLine("number {0} is negative", numbers[i]);
            }
        }

        // comparing first and last number
        int comparison = Compare(numbers[0], numbers[numbers.Length - 1]);

        if (comparison == 1){
            Console.WriteLine("The first number {0} is greater than last number {1}", numbers[0], numbers[numbers.Length - 1]);
        }
        else if (comparison == 0){
            Console.WriteLine("The first number {0} is equal to last number {1}", numbers[0], numbers[numbers.Length - 1]);
        }
        else{
            Console.WriteLine("The first number {0} is less than the last number {1}", numbers[0], numbers[numbers.Length - 1]);
        }
    }
}
