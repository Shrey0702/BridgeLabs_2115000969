using System;

class TemperatureCelciusToFahrenheit{
    public static void ConvertAndPrint(double celsius){
        double fahrenheit = (celsius * (9 / 5)) + 32; // formula for converting celcius to fahrenheit
        Console.WriteLine(string.Format("The {0} Celsius is {1} Fahrenheit", celsius, fahrenheit));
    }

    static void Main(){
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        ConvertAndPrint(celsius);
    }
}
