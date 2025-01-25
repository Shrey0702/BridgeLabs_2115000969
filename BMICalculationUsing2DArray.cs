using System;

class BMICalculationUsing2DArray{
    public static void Main() {
        // taking input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // creating a 2D array to store height, weight, and BMI for each person
        double[][] personData = new double[numPersons][];
        for (int i = 0; i < numPersons; i++) {
            personData[i] = new double[3];  // 3 columns - weight, height, and BMI
        }

        // creating an array to store weight statuses
        string[] weightStatuses = new string[numPersons];

        // taking input for weight and height of each person
        for (int i = 0; i < numPersons; i++) {
            Console.WriteLine("Enter details for Person {0}:", i + 1);

            // taking weight input with validation for positive value
            double weight;
            while (true){
                Console.Write("Enter weight in kgs: ");
                weight = double.Parse(Console.ReadLine());
                if (weight > 0) {
                    break; // exit the loop if weight is valid
                } else {
                    Console.WriteLine("Weight must be a positive value");
                }
            }

            // storing the weight in the personData array
            personData[i][0] = weight;

            // taking height input with validation for positive value
            double height;
            while (true) {
                Console.Write("Enter height in meters: ");
                height = double.Parse(Console.ReadLine());
                if (height > 0) {
                    break; // exit the loop if height is valid
                } else {
                    Console.WriteLine("Height must be a positive value");
                }
            }

            // storing the height in the personData array
            personData[i][1] = height;

            // calculating BMI and storing it in the personData array
            personData[i][2] = weight / (height * height);

            // determining the weight status based on BMI
            if (personData[i][2] <= 18.4) {
                weightStatuses[i] = "Underweight";
            } else if (personData[i][2] >= 18.5 && personData[i][2] <= 24.9) {
                weightStatuses[i] = "Normal weight";
            } else if (personData[i][2] >= 25.0 && personData[i][2] <= 39.9) {
                weightStatuses[i] = "Overweight";
            } else {
                weightStatuses[i] = "Obese";
            }
        }

        // displaying the BMI and weight status for each person
        Console.WriteLine("BMI Details for Each Person:");
        for (int i = 0; i < numPersons; i++) {
            Console.WriteLine("Person {0}: Height = {1} meters, Weight = {2} kg, BMI = {3}, Status = {4}",i + 1, personData[i][1], personData[i][0], personData[i][2], weightStatuses[i]);
        }
    }
}
