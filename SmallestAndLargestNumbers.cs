using System;

class RemainderAndQuotient{
    static void Main(){
        // Taking user input for the number and divisor
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        // calling the method to find the remainder and quotient
		// storing the value in an array - result
        int[] result = FindRemainderAndQuotient(number, divisor);

        // display the results
        Console.WriteLine("The quotient is: {0}", result[0]);
        Console.WriteLine("The remainder is: {0}", result[1]);
        
        
    }

   
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        // calculate the quotient
        int quotient = number / divisor;

        // calculate the remainder
        int remainder = number % divisor;

        // return the results as an array
        return new int[] { quotient, remainder };
    }
}
