using System;

class SquareSide{
    static void CalculateSide(double perimeter){
        // Calculating the side of the square
        double side = perimeter / 4;

        // Printing results
        Console.WriteLine("The length of the side is {0} whose perimeter is {1}.", side, perimeter);
    }

    static void Main(){
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = double.Parse(Console.ReadLine());

        CalculateSide(perimeter);
    }
}
