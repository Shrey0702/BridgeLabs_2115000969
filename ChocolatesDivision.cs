using System;

class ChocolatesDivision{
    static void Main(){
        // taking user input for the number of chocolates and number of children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // call the method to find the number of chocolates each child gets and the remainder
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        // display the results
        Console.WriteLine("Each child will get: {0} chocolates.", result[0]);
        Console.WriteLine("Remaining chocolates: {0}", result[1]);
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
