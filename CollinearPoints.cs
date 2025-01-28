using System;

class CollinearPoints{
    public static void Main()
    {
        // Take inputs for the three points (x1, y1), (x2, y2), (x3, y3)
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("Enter x3: ");
        double x3 = double.Parse(Console.ReadLine());

        Console.Write("Enter y3: ");
        double y3 = double.Parse(Console.ReadLine());

        // Check if the points are collinear using the slope formula
        bool areCollinearBySlope = AreCollinearBySlope(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Are the points collinear by slope formula? " + (areCollinearBySlope ? "Yes" : "No"));

        // Check if the points are collinear using the area of triangle formula
        bool areCollinearByArea = AreCollinearByArea(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Are the points collinear by area formula? " + (areCollinearByArea ? "Yes" : "No"));
    }

    // Method to check if the points are collinear using the slope formula
    public static bool AreCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate the slopes of the lines AB, BC, and AC
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        // Check if all the slopes are equal
        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    // Method to check if the points are collinear using the area of the triangle formula
    public static bool AreCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate the area of the triangle formed by the three points
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        // If the area is 0, then the points are collinear
        return area == 0;
    }
}
