using System;

class ConvertKmToMilesUser{
	public static void Converter(){
		Console.Write("Enter distance in Kilometers: ");
		float km = float.Parse(Console.ReadLine());
		float kmToMiles = 1.6f; // because 1 miles = 1.6km
		float distMiles = km /kmToMiles;
		Console.WriteLine(string.Format("The total miles is {0} mile for the given {1} km", distMiles, km));
	}
	
	public static void Main(){
		Converter();
	}
}