using System;

class AreaOfCircle{
	static void Main(){
		Console.Write("Enter the radius of the circle: ");      
        string input = Console.ReadLine();
        double r = double.Parse(input);
		double pi = Math.PI;
        double area = pi * r * r;    
        Console.WriteLine("The area of the circle is: " + area);
	}
}