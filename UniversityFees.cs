using System;


class UniversityFees{
	int fee;
	float discountPercent, discount, finalAmount;
	void DiscountCalculator(int feesAmount, int discountPerc){
		fee = feesAmount;
		discountPercent = discountPerc;
		discount = fee * (discountPercent/ 100);
		finalAmount = fee - discount;
		Console.WriteLine(string.Format("The discount amount is INR {0} and final discounted fee is INR {1}", discount, finalAmount));
	}
	
	public static void Main(){
		UniversityFees studentFees = new UniversityFees();
		studentFees.DiscountCalculator(125000, 10);
	}
}     