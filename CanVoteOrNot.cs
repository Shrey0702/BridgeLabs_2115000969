using System;

class CanVoteOrNot{
	static void CheckEligibleToVote(int age){
		// checking if the person is older than 18 or not
		if(age >= 18){
			Console.WriteLine("The person's age is {0} and can vote.", age);
		}
		else{
			Console.WriteLine("The person's age is {0} and cannot vote.", age);

		}
	}
	
	public static void Main(){
		Console.Write("Enter the age of a person in years: ");
		int age = int.Parse(Console.ReadLine());
		CheckEligibleToVote(age);
	}
}