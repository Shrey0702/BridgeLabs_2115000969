using System;

public class BMICalculator{
    // method to calculate BMI
    public static double CalculateBMI(double weight, double height){
        height = height / 100; // Convert height from cm to meters
        return weight / (height * height); // BMI formula
    }

    public static string BMIStatus(double bmi)
    {
        if(bmi <= 18.4){
			return "Underweight";
		}
        else if(bmi <= 24.9){
			return "Normal weight";
		}
        else if(bmi < 39.9){
			return "Overweight";
		}
        else{
		return "Obese";
		}
    }

    public static void Main(){
        double[,] data = new double[10, 3]; 

        // taking input for weight and height
        for (int i = 0; i < 10; i++){
            Console.Write("enter weight in kg for person " + (i + 1) + ": ");
            data[i, 0] = double.Parse(Console.ReadLine()); // weight
            Console.Write("enter height in cm for person " + (i + 1) + ": ");
            data[i, 1] = double.Parse(Console.ReadLine()); // height
			
			// calculating BMI
            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
        }

        // displaying the results
        Console.WriteLine("Person\tWeight    \tHeight   \tBMI\t\tStatus");
        for (int i = 0; i < 10; i++){
		// using this \t and 2D array index to print it like a report card
            string status = BMIStatus(data[i, 2]);
            Console.WriteLine((i + 1) + "\t" + data[i, 0] + "\t\t" + data[i, 1] + "\t\t" + data[i, 2].ToString("F2") + "\t" + status);
        }
    }
}