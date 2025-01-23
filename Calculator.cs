using System;
class Calculator
{
    static void Main()
    {
        // Declare variables
        double first, second, result = 0;
        string op;

        // input values from the user
        Console.WriteLine("Enter the first number:");
        first = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /):");
        op = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        second = double.Parse(Console.ReadLine());

        // Perform calculations 
        switch (op)
        {
            case "+":
                result = first + second;
                Console.WriteLine("Result: " + result);
                break;
                
            case "-":
                result = first - second;
                Console.WriteLine("Result: " + result);
                break;
                
            case "*":
                result = first * second;
                Console.WriteLine("Result: " + result);
                break;
                
            case "/":
                // Check if second number is zero to prevent division by zero
                if (second != 0)
                {
                    result = first / second;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                break;

            default:
                Console.WriteLine("Invalid Operator.");
                break;
        }
    }
}
