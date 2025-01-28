using System;

class NaturalNumbersRecursion{
    static void Main(){
        // taking user input
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // checking if the number is natural or not
        if (n <= 0){
            Console.WriteLine("The input is not a natural number");
            return;
        }

        // calculating using recursion
        int recursiveSum = SumRecursive(n);

        // calculating the sum using the formula
        int formulaSum = SumUsingFormula(n);

        // display the results
        Console.WriteLine("sum using recursion: ", recursiveSum);
        Console.WriteLine("sum using formula: {1}", formulaSum);

		// comparing the results
        if (recursiveSum == formulaSum){
            Console.WriteLine("our recursion method is working fine both the methods calculateed same result");
        }
        else{
            Console.WriteLine("there is some problem with our recursion or formula the answer are not matching");
        }
	}
 
	public static int SumRecursive(int n){
 
		// below line will work as a base case to move out of recursion call
        if (n == 1){
            return 1;
        }
        return n + SumRecursive(n - 1);
    }

    
    public static int SumUsingFormula(int n){
        return n * (n + 1) / 2;
    }
}
