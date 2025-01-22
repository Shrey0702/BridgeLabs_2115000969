using System;

class DistanceConverter{
    static void ConvertKilometersToMiles(){
        double kilometers = 10.8;

        // Conversion values 1 km = 1.6 miles
        double miles = kilometers / 1.6;

        Console.WriteLine(string.Format("The distance {0} km in miles is {1}.", kilometers, miles));
    }

    static void Main(){
        ConvertKilometersToMiles();
    }
}
