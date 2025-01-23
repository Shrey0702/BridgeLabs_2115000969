using System;

class OddEvenNumbers{
    static void DisplayOddEvenNumbers(int number){

        if (number > 0){
            for (int i = 1; i <= number; i++){
                if (i % 2 == 0){
                    Console.WriteLine("The number {0} is even", i);
                }
                else{
                    Console.WriteLine("The number {0} is odd", i);
                }
            }
        }
        else{
            Console.WriteLine("Please enter a number greater than 0");
        }
    }

    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        DisplayOddEvenNumbers(number);
    }
}
