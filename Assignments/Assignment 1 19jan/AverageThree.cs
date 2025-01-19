using System;

class AverageThree{
	static void Main(){
		Console.WriteLine("Enter the value of all the numbers one by one after pressing enter each time: ");      
        string input1 = Console.ReadLine();
        int num1 = Convert.ToInt32(input1);
		
		string input2 = Console.ReadLine();
        int num2 = Convert.ToInt32(input1);
		
		string input3 = Console.ReadLine();
        int num3 = Convert.ToInt32(input1);
		
		double res = (num1 + num2 + num3)/3;
		Console.WriteLine("The average of three numbers is: " + res);
	}

}