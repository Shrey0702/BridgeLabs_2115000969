using System;

class KilometersToMiles{
	static void Main(){
		Console.Write("Enter the distance in kilometers: ");      
        string input1 = Console.ReadLine();
        float km = float.Parse(input1);
		double miles = km * 0.621371;
		Console.WriteLine(string.Format("{0} kilometers is equal to {1} miles", km, miles));
	}
}