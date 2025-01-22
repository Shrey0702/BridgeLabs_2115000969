using System;

class ChocolateDistribution{
    public static void DistributeChocolates(int numberOfChocolates, int numberOfChildren){
        // Calculating number of chocolates each child will get
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
		// reaminder will give us remaining chocolates 
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        Console.WriteLine(string.Format("The number of chocolates each child gets is {0} and the number of remaining chocolates is {1}.", 
                                        chocolatesPerChild, remainingChocolates));
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        DistributeChocolates(numberOfChocolates, numberOfChildren);
    }
}
