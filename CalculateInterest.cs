using System;

class CalculateInterest{
    static void Main(){
        // Taking user input
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

		CalculateSimpleInterest(principal, rate, time);

        
    }

    static void CalculateSimpleInterest(double principal, double rate, double time){
	
		// Calculating Simple Interest
        double simpleInterest = (principal * rate * time) / 100;;
		// Printing the result using string format
        Console.WriteLine("The Simple Interest is {0} for Principal {1}, Rate of Interest {2}%, and Time {3} years", simpleInterest, principal, rate, time);
        
    }
}
