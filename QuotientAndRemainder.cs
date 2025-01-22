using System;

class QuotientAndRemainder{
    static void CalculateQuotientAndRemainder(int number1, int number2){
        // calculating quotient
        int quotient = number1 / number2;
		// calculating remainder
        int remainder = number1 % number2;

        Console.WriteLine(string.Format("The Quotient is {0} and Remainder is {1} of two numbers {2} and {3}", quotient, remainder, number1, number2));
    }

    static void Main(){
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        CalculateQuotientAndRemainder(number1, number2);
    }
}
