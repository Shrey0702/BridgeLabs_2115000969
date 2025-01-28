using System;

class HandShakes{
    static void Main(){
        // Taking user input
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calling the method to calculate and print the maximum number of handshakes
        CalculateAndPrintHandshakes(numberOfStudents);
    }
	
    static void CalculateAndPrintHandshakes(int n){
       
        // Using the given formula
        int handshakes = (n * (n - 1)) / 2;
		// Printing the result
        Console.WriteLine("The maximum number of handshakes among {0} students is {1}", n, handshakes);
       
    }
}
