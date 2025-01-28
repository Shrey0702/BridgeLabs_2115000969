using System;

class RandomNumbers{
    public static void Main(){
        // calling method
        int[] randomNumbers = Generate4DigitRandomArray(5);

        // finding the average, min, and max values
        double[] result = FindAverageMinMax(randomNumbers);

        Console.WriteLine("generated 4-digit random numbers:");
        foreach (int num in randomNumbers){
            Console.WriteLine(num);
        }

        Console.WriteLine("\nAverage: " + result[0]);
        Console.WriteLine("Minimum: " + result[1]);
        Console.WriteLine("Maximum: " + result[2]);
    }

    // method to generate an array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int size){
        Random rand = new Random();
        int[] randomNumbers = new int[size];

        for (int i = 0; i < size; i++){
            randomNumbers[i] = rand.Next(1000, 10000); 
        }

        return randomNumbers;
    }

    // method to find average, min, and max values from an array
    public static double[] FindAverageMinMax(int[] numbers){
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers){
            sum += num;
            min = Math.Min(min, num); // finding minimum
            max = Math.Max(max, num); // finding maximum
        }

        double average = sum / numbers.Length;

        return new double[] { average, min, max };
    }
}
