using System;

class SimpleInterestCalculator{
    public static void CalculateSimpleInterest(double principal, double rate, double time){
        // calculating simple interest
        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine(string.Format("The Simple Interest is {0} for Principal {1}, Rate of Interest {2} and Time {3}.", 
                                        simpleInterest, principal, rate, time));
    }

    public static void Main(){
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time period (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        CalculateSimpleInterest(principal, rate, time);
    }
}
