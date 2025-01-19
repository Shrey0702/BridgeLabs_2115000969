using System;

class PowerCalculation{
	static void Main(){
		Console.Write("Enter the value of base: ");      
        string input1 = Console.ReadLine();
        int base1 = Convert.ToInt32(input1);
		
		
		Console.Write("Enter the value of exponent: ");      
        string input2 = Console.ReadLine();
        int exponent = Convert.ToInt32(input2);
		
		double res = Math.Pow(base1, exponent);
		Console.WriteLine("The result is: " + res);
	
	}
}