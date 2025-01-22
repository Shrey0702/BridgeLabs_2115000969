using System;

class UserUniversity
{
	float fee;
	float discountPercent;
	public UserUniversity(float fee, float discountPercent)
	{
		this.fee = fee;
		this.discountPercent = discountPercent;
	}
	
	
	// method to find the discounted amount and payable account for student
	public void DiscountedFee()
	{
		float discountedAmount = fee * discountPercent / 100;
		float payableAmount = fee - discountedAmount;
		Console.WriteLine(string.Format("The discount amount is INR {0} and final discounted fee is INR {1}", discountedAmount, payableAmount));
	}
}

class Program
{
	static void Main()
	{
		Console.Write("Enter fee of university");
		float fee = Convert.ToSingle(Console.ReadLine());
		Console.Write("Enter discount percentage");
		float discountPercent = Convert.ToSingle(Console.ReadLine());
		
		UserUniversity run = new UserUniversity(fee, discountPercent);
		run.DiscountedFee();
	}
}