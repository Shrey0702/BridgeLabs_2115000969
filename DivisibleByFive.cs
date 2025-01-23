using System;

class DivisibleByFive{
    // checking if the number is divisible by 5
    static void CheckDivisibilityBy5(int number){
        if (number % 5 == 0){   // if the remainder is 0, then the number is completely divisible by 5
            Console.WriteLine(string.Format("Is the number {0} divisible by 5? Yes", number));
        }
        else{   // if this else statement is reached then we can say that the number isn't divisible by 5
            Console.WriteLine(string.Format("Is the number {0} divisible by 5? No", number));
        }
    }

    static void Main(){
        Console.Write("Enter a number: ");
        int number = Int32.Parse(Console.ReadLine());
        CheckDivisibilityBy5(number);
        
    }
}
