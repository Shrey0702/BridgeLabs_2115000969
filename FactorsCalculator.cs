using System;

class FactorsCalculator{
    static void Main(){
        // taking user input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // call method to find factors
        int[] factors = FindFactors(number);

        // display the factors
        Console.Write("Factors of {0}: ", number);
        for (int i = 0; i < factors.Length; i++){
            Console.Write(factors[i]);
            if (i < factors.Length - 1){
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        // calculate and display the sum of factors
        int sumOfFactors = CalculateSumOfFactors(factors);
        Console.WriteLine(String.Format("Sum of factors: {0}", sumOfFactors));

        // calculate and display the product of factors
        long productOfFactors = CalculateProductOfFactors(factors);
        Console.WriteLine(String.Format("Product of factors: {0}", productOfFactors));

        // calculate and display the sum of squares of factors
        int sumOfSquares = CalculateSumOfSquares(factors);
        Console.WriteLine(String.Format("Sum of squares of factors: {0}", sumOfSquares));
    }

    
    public static int[] FindFactors(int number){
        // first loop to count the number of factors
        int count = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                count++;
            }
        }

        // initialize array to store factors
        int[] factors = new int[count];

        // second loop to store factors into the array
        int index = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                factors[index++] = i;
            }
        }

        return factors;
    }

   
    public static int CalculateSumOfFactors(int[] factors){
        int sum = 0;
        foreach (int factor in factors){
            sum += factor;
        }
        return sum;
    }

   
    public static long CalculateProductOfFactors(int[] factors){
	// used long because value might go out of range for int
        long product = 1;
        foreach (int factor in factors){
            product *= factor;
        }
        return product;
    }

   
    public static int CalculateSumOfSquares(int[] factors){
        int sum = 0;
        foreach (int factor in factors){
            sum += (int)Math.Pow(factor, 2);
        }
        return sum;
    }
}
