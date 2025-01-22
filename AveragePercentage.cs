using System;

class AveragePercentage{
    public int CalculatePercentage(int marksMath, int marksPhysics, int marksChemistry){
		//calculating percentage
        int resultPerc = (marksMath + marksPhysics + marksChemistry) / 3;
        return resultPerc;
    }

    public static void Main(){
        AveragePercentage obj = new AveragePercentage(); // creating the object to use the method
        int res = obj.CalculatePercentage(94, 95, 96);
        Console.WriteLine(string.Format("Sam’s average mark in PCM is {0}", res));
    }
}
