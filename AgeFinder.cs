using System;

class AgeFinder{
	int currentYear = 2024;
	
	public void CalculateAge(int yrBirth){
		// checking edge case - if currentYear > yrBirth
		if(yrBirth > currentYear){
			Console.WriteLine("Invalid input, the person will be born in the near future :)");
			return;
		}
		// calculating actual age
		int age = currentYear - yrBirth;
		Console.WriteLine("Harry's age in 2024 is " + age);
	}
	
	public static void Main(){
		// need to create object of the containing class to call non-static method inside static method 
		AgeFinder harryAge = new AgeFinder();
		harryAge.CalculateAge(2025);
	}
}