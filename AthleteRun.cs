using System;

class AthleteRun{
    public static void ComputeRounds(double side1, double side2, double side3){
        double perimeter = side1 + side2 + side3; // calculating perimeter

        double totalDistance = 5000;

        double rounds = totalDistance / perimeter;  // calculating rounds 

        Console.WriteLine(string.Format("The total number of rounds the athlete will run is: {0}", rounds));
    }

    public static void Main(string[] args){
        Console.Write("Enter the length of side 1 of the triangle (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 of the triangle (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 of the triangle (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        ComputeRounds(side1, side2, side3);
    }
}
