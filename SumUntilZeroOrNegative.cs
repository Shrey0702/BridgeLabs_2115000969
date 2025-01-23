using System;

class SumUntilZeroOrNegative{
    static void CalculateSum(){
        double total = 0.0; 


        while (true){
            Console.Write("Enter a number (if want to stop adding enter 0 or a negative number): ");
            double input = double.Parse(Console.ReadLine()); 
			// used or(||) operator so if atleast one of the condition holds true it will break the loop
            if ((input == 0) || input < 0){  // it will break the infinite while loop if input == 0 or input < 0
                break; 
			}

            total += input; // calculating sum and storing it in a variable
        }

        Console.WriteLine("The total sum of the numbers entered is {0}", total);
    }

    static void Main(){
        CalculateSum();
    }
}
