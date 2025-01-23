using System;

class FactorialUsingFor{
	static void CalculateFactorial(int number){
	double factorial = 1;  // initialised with 1 because if we initialised with 0 it will always be 0 when multiplying
	for(int i = 1; i <= number; i++){  
		factorial *= i;
	}
	Console.WriteLine("The factorial of the number is {0}", factorial);
}
	
	public static void Main(){
		Console.Write("Enter the number: ");
		int number = int.Parse(Console.ReadLine());
		CalculateFactorial(number);
	}
}


	
