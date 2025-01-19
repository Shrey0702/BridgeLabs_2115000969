using System;

class SimpleInterest{
	static void Main(){
		Console.Write("Enter principal amount: ");
		string input1 = Console.ReadLine();
		float principal = float.Parse(input1);
		Console.Write("Enter rate of interest: ");
		string input2 = Console.ReadLine();
		float rate = float.Parse(input2);
		Console.Write("Enter time in years: ");
		string input3 = Console.ReadLine();
		float time = float.Parse(input3);
		
		float simpleInterest = (principal * rate * time)/100;
		Console.WriteLine("The Simple Interest will be " + simpleInterest);
		
	}
}