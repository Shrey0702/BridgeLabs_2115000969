using System;

class PensDistribution{
	// using protected access modifier for the method
	protected static void CalculateEqualAndReamining(int pens, int students){
		// finding equal amount of pens to be distributed
		int pensDistEqually = pens/ students; // it will return the quotient
		
		int remainingPens = pens % students; // because % gives remainder, which is the number of remaining pens
		
		Console.WriteLine(string.Format("The Pen Per Student is {0} and the remaining pen not distributed is {1}", pensDistEqually, remainingPens));
	}
	
	public static void Main(){
		PensDistribution.CalculateEqualAndReamining(14, 3); // protected method within the same class can be called without creating an object
	}
}