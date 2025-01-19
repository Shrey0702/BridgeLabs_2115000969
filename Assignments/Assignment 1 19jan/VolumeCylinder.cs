using System;

class VolumeCylinder{
	static void Main(){
		Console.Write("Enter radius of the cylinder: ");
		string input1 = Console.ReadLine();
		double radius = double.Parse(input1);
		
		Console.Write("Enter height of the cylinder: ");
		string input2 = Console.ReadLine();
		double height = double.Parse(input2);
		double pi = Math.PI;
		double volume = pi * radius * radius * height;
		Console.WriteLine(volume);
		
	
	}
}