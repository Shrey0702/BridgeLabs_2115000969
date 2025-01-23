using System;

class FactorialUsingWhile{
	static void CalculateFactorial(int number){
	int factorial = 1;  // initialised with 1 because if we initialised with 0 it will always be 0 when multiplying
	while(number > 0){  
		factorial *= number;
		number--;
	}
	Console.WriteLine("The factorial of the number is {0}", factorial);
}
	
	public static void Main(){
		Console.Write("Enter the number: ");
		int number = int.Parse(Console.ReadLine());
		CalculateFactorial(number);
	}
}


	
