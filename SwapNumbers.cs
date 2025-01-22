using System;

class SwapNumbers{
    public static void SwapNums(double number1, double number2){
        // swapping the numbers
        double temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine(string.Format("The swapped numbers are {0} and {1}", number1, number2));
    }

    static void Main(){
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        SwapNums(number1, number2);
    }
}
