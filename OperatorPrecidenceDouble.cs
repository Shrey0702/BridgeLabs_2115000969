using System;

class OperatorPrecidenceDouble
{
    static void Main()
    {
        // input double values from user
        Console.Write("Enter the value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // double operations
        double result1 = a + b * c;    // Multiplication (*) is performed before addition (+)
        double result2 = a * b + c;    // Multiplication (*) is performed before addition (+)
        double result3 = c + a / b;    // Division (/) is performed before addition (+)
        double result4 = a % b + c;    // Modulus (%) is performed before addition (+)
		// result
		Console.WriteLine("The results of Int Operations are {0}, {1}, {2} and {3}", result1, result2, result3, result4);
	}
}
// precidence order from highest to lowest () | * / % | + - 