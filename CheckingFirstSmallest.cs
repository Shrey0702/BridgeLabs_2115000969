using System;

class CheckingFirstSmallest{
    static void CheckIfFirstSmallest(int number1, int number2, int number3){
        if (number1 < number2 && number1 < number3){  
		// it will check for possiblity if first is smaller than second as well as third
            Console.WriteLine(string.Format("Is the first number the smallest? Yes"));
        }
        else{  
		// for all the cases except the if statement will lie here
            Console.WriteLine(string.Format("Is the first number the smallest? No"));
        }
    }

    static void Main(){
		// taking input one by one
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        CheckIfFirstSmallest(number1, number2, number3);
    }
}
