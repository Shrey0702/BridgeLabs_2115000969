using System;

class CheckingStudentCanVote{
	public static void Main(){
		// initialising array
		int [] studentAges = new int[10];
		// adding student ages using for loop to iterate through every element
		for(int i = 0; i < studentAges.Length; i++){
			Console.Write("Enter the age: ");
			studentAges[i] = int.Parse(Console.ReadLine());
		}
		// calling the method to check the age
		AbleToVote(studentAges);
	}
	
	static void AbleToVote(int[] ages){
		// using for each loop to to validate the age
		// foreach loop stores the value itself not just the location
		foreach(int age in ages){
			// cheking if student can vote
			if(age >= 18){
				Console.WriteLine("Student with age {0} can vote", age);
			}
			// checking if student canot vote
			else if(age >= 0 && age < 18){
				Console.WriteLine("Student with age {0} can vote", age);
			}
			// checking if input is negative
			else{
				// using Console.Error to write print the error
				Console.Error.WriteLine("Invalid Input");
			}
		}
	}
}