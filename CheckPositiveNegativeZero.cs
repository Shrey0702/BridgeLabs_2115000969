using System;

class CheckPositiveNegativeZero{
	static void CheckingNumber(int number){
		// checking for 0
		if(number == 0){
			Console.WriteLine("zero");
		}
		
		// checking if the number is positive
		else if(number > 0){
			Console.WriteLine("positive");
		}
		// checking if the number is negative
		else if(number < 0){
			Console.WriteLine("negative");
		}
		
	}
	
	public static void Main(){
		Console.Write("Enter the number: ");
		int number = int.Parse(Console.ReadLine());
		CheckingNumber(number);
	}
}