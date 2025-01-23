using System;

class NaturalNumberUsingForLoop{
	static void IsNatural(int num){
		if(num > 0){
			int sumUsingFormula = num * (num + 1)/ 2;
			int sumUsingFor = 0;
			// using for loop to calculate the sum
			for(int i = 0; i <= num; i++){  // we can also use reverse loop if we want
				sumUsingFor += i;
			}
			// displaying both the results
			Console.WriteLine("The sum of {0} natural numbers is {1} using formula and {2} using for loop", num, sumUsingFormula, sumUsingFor);
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