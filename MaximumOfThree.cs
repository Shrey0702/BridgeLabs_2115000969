using System;

class MaximumOfThree{
	//declarimg properties of class
	int num1;
	int num2;
	int num3;
	//method to take input
	public  void input(){
		Console.Write("Enter first number: ");
		num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter second number: ");
		num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter third number: ");		
		num3 = Convert.ToInt32(Console.ReadLine());
	}
	// method to find the maximum among 3 called by which instance or object matters
	public  void CheckMaximum(){
		if(num1 > num2 && num1 > num3){
			Console.WriteLine("Maximum of {0} , {1} and {2} is: {0}", num1, num2, num3);
		}
		
		else if(num2 > num1 && num2 > num3){
			Console.WriteLine("Maximum of {0} , {1} and {2} is: {1}", num1, num2, num3);
		}
		else{
			Console.WriteLine("Maximum of {0} , {1} and {2} is: {2}", num1, num2, num3);
		}
	}
	
	static void Main(string[] args){
		MaximumOfThree run = new MaximumOfThree();
		run.input();//calling method
		run.CheckMaximum();// calling method
	}
}
