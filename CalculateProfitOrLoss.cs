using System;

class CalculateProfitOrLoss{
	// this time implementing static method
	public static void CalculateProfit(int costPrice, int sellingPrice){
		float profit = sellingPrice - costPrice;
		float profitPercentage = (profit/ costPrice) * 100;  // only converted profit from int to float so costPrice will be implicitly converted to float
		// no need to add brackets because presedense of / > * 
		Console.WriteLine(string.Format("The Cost Price is INR {0} and Selling Price is INR {1}\nThe Profit is INR {2} and the Profit Percentage is {3}", costPrice, sellingPrice, profit, profitPercentage));
	}
	
	public static void Main(){
		CalculateProfitOrLoss.CalculateProfit(129, 191); // we just need class name and then method name to call static methods
	}
}