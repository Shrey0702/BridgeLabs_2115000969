using System;

class UnitConverter{
    static void Main(){
	// it is not mentioned to take user input so creating code without user input
		// kilometers to miles
        double milesDist = KmToMiles(10);
        Console.WriteLine("{0} km  = {1} miles", 10, milesDist);

        // miles to kilometers
		double kmDist = MilesToKm(10);
        Console.WriteLine("{0} miles = {1} km", 10, kmDist);

        // meters to feet
		double mtr = MetersToFeet(5);
        Console.WriteLine("{0} meters = {1} feet", 5, mtr);

        // feet to meters
		double feet = FeetToMeters(5);
        Console.WriteLine("{0} feet = {1} meters", 5, feet);
    }

    
    public static double KmToMiles(double km){
        double km2miles = 0.621371;
        return km * km2miles;
    }

   
    public static double MilesToKm(double miles){
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    
    public static double MetersToFeet(double meters){
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

   
    public static double FeetToMeters(double feet){
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
}
