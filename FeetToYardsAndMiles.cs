using System;

class FeetToYardsAndMiles{
    static void ConvertDistance(double distanceInFeet){
        // Converting feet to yards and miles
        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;

        // Printing results
        Console.WriteLine("The distance of {0} feet is equal to {1} yards and {2} miles", distanceInFeet, distanceInYards, distanceInMiles);
    }

    static void Main(){
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = double.Parse(Console.ReadLine());
		ConvertDistance(distanceInFeet);
    }
}
