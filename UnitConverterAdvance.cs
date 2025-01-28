using System;

class UnitConverterAdvance{
    static void Main(){

        // fahrenheit to celsius
		double celsius = FahrenheitToCelsius(100);
        Console.WriteLine("{0}F = {1}C", 100, celsius);

        // celsius to fahrenheit
		double fahrenheit = CelsiusToFahrenheit(100);
        Console.WriteLine("{0}C = {1}F", 100, fahrenheit);

        // pounds to kilogram
		double kilograms = PoundToKilograms(50);
        Console.WriteLine("{0} pounds = {1} kilograms", 50, kilograms);

        // kilograms to pounds
		double pounds = KilogramToPounds(50);
        Console.WriteLine("{0} kilograms = {1} pounds", 50, pounds);

        // gallons to liters
		double liters = GallonToLiters(200);
        Console.WriteLine("{0} gallons = {1} liters", 200, liters);

        // liters to gallons
		double gallons = LiterToGallons(200);
        Console.WriteLine("{0} liters = {1} gallons", 200, gallons);
    }

    
    public static double FahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }

    
    public static double CelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }

    
    public static double PoundToKilograms(double pounds){
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    
    public static double KilogramToPounds(double kilograms){
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    
    public static double GallonToLiters(double gallons){
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    
    public static double LiterToGallons(double liters){
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}
