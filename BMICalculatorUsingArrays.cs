using System;

class BMICalculatorUsingArrays{
    public static void Main(){
        // taking input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // creating arrays
        double[] weights = new double[numPersons];
        double[] heights = new double[numPersons];
        double[] bmis = new double[numPersons];
        string[] weightStatuses = new string[numPersons];

        // taking input for weight and height of each person
        for (int i = 0; i < numPersons; i++){
            Console.WriteLine("Enter details for Person {0}:", i + 1);

            // taking weight input
            Console.Write("Enter weight in kgs: ");
            weights[i] = double.Parse(Console.ReadLine());

            // taking height input
            Console.Write("Enter height in meters: ");
            heights[i] = double.Parse(Console.ReadLine());

            // calculating BMI using given formula
            bmis[i] = weights[i] / (heights[i] * heights[i]);

            // determing weight status based on BMI
            if (bmis[i] <= 18.4){
                weightStatuses[i] = "Underweight";
			}
            else if(bmis[i] >= 18.5 && bmis[i] <= 24.9){
                weightStatuses[i] = "Normal weight";
			}
            else if(bmis[i] >= 25.0 && bmis[i] <= 39.9){
                weightStatuses[i] = "Overweight";
			}
            else{
                weightStatuses[i] = "Obese";
			}
        }

        // displaying the BMI and weight status for each person
        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("Person {0}: Height = {1:F2} meters, Weight = {2:F2} kg, BMI = {3:F2}, Status = {4}", i + 1, heights[i], weights[i], bmis[i], weightStatuses[i]);
        }
    }
}
