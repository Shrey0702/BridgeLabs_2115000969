using System;

class TemperatureFahrenheitToCelsius{
    public static void ConvertAndPrint(double fahrenheit){
        double celsius = (fahrenheit - 32) * 5 / 9;  // formula to convert
        Console.WriteLine(string.Format("The {0} Fahrenheit is {1} Celsius", fahrenheit, celsius));
    }

    static void Main(){
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        ConvertAndPrint(fahrenheit);
    }
}
