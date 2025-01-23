using System;

class NaturalNumberUsingWhileLoop{
	static void IsNatural(int num){
		if(num > 0){
			int sumUsingFormula = num * (num + 1)/ 2;
			int temp = num;
			int sumUsingWhile = 0;
			// using while loop to calculate the sum
			while(temp > 0){
				sumUsingWhile += temp;
				temp--;
			}
			// displaying both the results
			Console.WriteLine("The sum of {0} natural numbers is {1} using formula and {2} using while loop", num, sumUsingFormula, sumUsingWhile);
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