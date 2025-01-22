using System;

class HeightConversion{
	// creating static method
    static void ConvertAndDisplayHeight(double heightCm){
        // converting centimeters to inches
        double heightInInches = heightCm/ 2.54;

        // Calculating feet and remaining inches
        int feet = (int)(heightInInches / 12);  // it will calculate the feet in integer form
        double inches = Math.Round(heightInInches % 12, 2); // remainder is the inches

        // Displaying the result
        Console.WriteLine(string.Format("Your Height in cm is {0} , while in feet is {1} and inches is {2}", heightCm, feet, inches));
    }
    static void Main(){
        Console.Write("Enter height in centimeters: ");
        double heightCm = double.Parse(Console.ReadLine());
        ConvertAndDisplayHeight(heightCm); //directly calling the method
    }

}
