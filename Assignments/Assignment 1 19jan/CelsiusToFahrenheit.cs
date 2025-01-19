using System;

class CelsiusToFahrenheit{
	static void Main(){
		Console.WriteLine("Enter temperature in celcius below: ");
		string input = Console.ReadLine();
		float celsius = float.Parse(input);
		float tempFahrenheit = (celsius * (9/5)) + 32;
		Console.WriteLine("the temperature in fahrenheit " + tempFahrenheit);
	}

}