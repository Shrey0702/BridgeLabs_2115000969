using System;

class AddNumbers{
	static void Main(){
		Console.WriteLine("Enter the first number below: ");
        string input1 = Console.ReadLine(); 
        int number1 = Convert.ToInt32(input1); 


        Console.WriteLine("Enter the second number below: ");
        string input2 = Console.ReadLine(); 
        int number2 = Convert.ToInt32(input2); 

        
        int sum = number1 + number2;

        
        Console.WriteLine(string.Format("The addition of {0} and {1} is {2}), number1, number2, sum);
	}
	

}