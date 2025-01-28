using System;

class Factors{
    static void Main(){
	// we are creating seperate methods for each calculation
        // take user input for the number
        Console.Write("enter: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // find the factors by calling the FindFactors method
        int[] factors = FindFactors(number);

        // displaying the factors
        Console.Write("factors of {0}: ", number);
        for (int i = 0; i < factors.Length; i++){
            Console.Write(factors[i]);
            if (i < factors.Length - 1){
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        // finding sum of the factors
        int sum = SumOfFactors(factors);
        Console.WriteLine("sum of factors: {0}", sum);

        // finding the product
        long product = ProductOfFactors(factors);
        Console.WriteLine("product of factors: {0}", product);

        // finding sum of squares
        int sumOfSquares = SumOfSquaresOfFactors(factors);
        Console.WriteLine("sum of squares of factors: {0}", sumOfSquares);
    }

   
    public static int[] FindFactors(int number){
        // loop to count the number of factors
        int count = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                count++;
            }
        }

        // creating array for factors
		// we used count in above looop to find the number of elements which we will be storing in the array
        int[] factors = new int[count];

        // loop to store the factors into the array
        int index = 0;
        for (int i = 1; i <= number; i++){
		// this if contion will be true only if the number is completely divisible by i
            if (number % i == 0){
                factors[index++] = i;  // storing the factor at index and then incrementing index by 1
            }
        }

        return factors;
    }

    
    public static int SumOfFactors(int[] factors){
        int sum = 0;
		// using for each loop to iterate over the array factors
        foreach (int factor in factors){
            sum += factor;
        }
        return sum;
    }

   
    public static long ProductOfFactors(int[] factors){
        long product = 1;
        foreach (int factor in factors){
            product *= factor;
        }
        return product;
    }

  
    public static int SumOfSquaresOfFactors(int[] factors){
        int sumOfSquares = 0;
        foreach (int factor in factors){
		// it will calculate x^2 for the factor and then add it to sumOfSquares
            sumOfSquares += (int)Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }
}
