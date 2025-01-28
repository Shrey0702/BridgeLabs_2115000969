using System;

class AthleteRounds{
    static void Main(){
        // taking user input for the three sides of the triangular park
		// using doubl because sides can be in in decimal values too
        Console.Write("Enter the length of side 1 in meters: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 in meters: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 in meters: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // call the method to calculate and display the number of rounds
        CalculateAndDisplayRounds(side1, side2, side3);
    }

   
    static void CalculateAndDisplayRounds(double side1, double side2, double side3){
        // calculating the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // converting 5 km to meters
        double distanceToRun = 5000; // 5 km = 5000 meters

        double rounds = distanceToRun / perimeter;

        // display the result
		// used Math.ceiling to display complete rounds
        Console.WriteLine("The athlete needs to complete {0} rounds to complete a 5 km run.", Math.Ceiling(rounds));
	}
}
