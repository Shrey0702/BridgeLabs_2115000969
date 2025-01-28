using System;

class EuclideanDistance
{
    public static void Main()
    {
        // Take input for the two points
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate and display the Euclidean distance
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine("The Euclidean distance between the two points is: {0:F2}", distance);

        // Calculate and display the equation of the line
        double[] lineEquation = GetLineEquation(x1, y1, x2, y2);
        Console.WriteLine("The equation of the line is: y = {0:F2}*x + {1:F2}", lineEquation[0], lineEquation[1]);
    }

    // Method to calculate the Euclidean distance between two points
    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    // Method to calculate the equation of the line given two points
    public static double[] GetLineEquation(double x1, double y1, double x2, double y2)
    {
        // Calculate the slope (m) of the line
        double m = (y2 - y1) / (x2 - x1);

        // Calculate the y-intercept (b) of the line
        double b = y1 - m * x1;

        // Return both slope and y-intercept in an array
        return new double[] { m, b };
    }
}
