using System;

class NegativePositiveZero{
    static void Main(string[] args){
        // integer input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // call the method to determine the type of number
        int result = CheckNumberType(number);

        // display the result based on the returned value
		// below conditions will check for compare the result sent through CheckNumberType() method
        if (result == 1)
        {
            Console.WriteLine("The number is positive");
        }
        else if (result == -1)
        {
            Console.WriteLine("The number is negative");
        }
        else
        {
            Console.WriteLine("The number is zero");
        }
    }

    // using int type for return because we need to send an integer value back to the method call
    static int CheckNumberType(int number){
        if (number > 0){
            return 1;
        }
        else if (number < 0){
            return -1;
        }
        else{
            return 0;
        }
    }
}
