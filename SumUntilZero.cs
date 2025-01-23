using System;

class SumUntilZero{
    static void CalculateSumUntilZero(){
        double total = 0.0; 


        while (true){
            Console.Write("Enter a number: (if want to stop adding enter 0) ");
            double input = double.Parse(Console.ReadLine()); 
            if (input == 0){  // it will break the infinite while loop
                break; 
			}

            total += input; // calculating sum and storing it in a variable
        }

        Console.WriteLine("The total sum of the numbers entered is {0}", total);
    }

    static void Main(){
        CalculateSumUntilZero();
    }
}
