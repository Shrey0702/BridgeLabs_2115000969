using System;

class TriangleArea
{
    static void CalculateTriArea(double baseInInches, double heightInInches)
    {
        // Calculating area in square inches
        double areaInInches = 0.5 * baseInInches * heightInInches; // calculating area in inches

        // Converting inches to centimeters -- 1 inch = 2.54 cm
        double baseInCm = baseInInches * 2.54;
        double heightInCm = heightInInches * 2.54;
        double areaInCm = 0.5 * baseInCm * heightInCm; // calculating area in centimeters

        // Printing results
        Console.WriteLine(string.Format(
            "The area of the triangle with base {0} inches and height {1} inches is {2} square inches and {3} square centimeters",
            baseInInches, heightInInches, areaInInches, areaInCm));
    }

    static void Main()
    {
        Console.Write("Enter the base of the triangle in inches: ");
        double baseInInches = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the triangle in inches: ");
        double heightInInches = double.Parse(Console.ReadLine());

        CalculateTriArea(baseInInches, heightInInches);
    }
}
