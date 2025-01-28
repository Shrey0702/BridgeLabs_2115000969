using System;

class WindChillCalculator{
    static void Main(){
        // taking user input for temperature and wind speed
        Console.Write("Enter the temperature in Fahrenheit: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the wind speed in mph: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());


        // call the method to calculate wind chill
        double windChill = WindChill(temperature, windSpeed);

        // display the result
        Console.WriteLine("The wind chill temperature is: {0}°F", windChill);
    }

    public static double WindChill(double temperature, double windSpeed){
        // calculate wind chill using the given formula
        double windChill = 35.74 + (0.6215 * temperature) + ((0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16));
        return windChill;
    }
}
