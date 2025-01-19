using System;

class PerimeterRectangle{
	static void Main(){
		Console.Write("Enter the length of the rectangle: ");      
        string input1 = Console.ReadLine();
        float length = float.Parse(input1);
		
		
		Console.Write("Enter the width of the rectangle: ");      
        string input2 = Console.ReadLine();
        float width = float.Parse(input2);
		
		float perimeter = 2 * (length + width);
		Console.WriteLine("Perimeter of the rectangle is " + perimeter);
	}
}