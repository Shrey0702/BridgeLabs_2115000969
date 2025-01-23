using System;

class CheckingNaturalNumber{
	static void IsNatural(int num){
		if(num > 0){
			int sumNatural = num * (num + 1)/ 2;
			Console.WriteLine("The sum of {0} natural numbers is {1}", sumNatural, num);
		}
		else{
			Console.WriteLine("The number {0} is not a natural number", num);
		}
	}
	
	public static void Main(){
		Console.Write("Enter the number: ");
		int number = int.Parse(Console.ReadLine());
		IsNatural(number);
	}

}