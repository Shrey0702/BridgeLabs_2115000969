using System;

class MeanHeightFootballTeam{
    public static void Main(){
        // creating an array to store the height of players
        double[] heights = new double[11];
        double sum = 0.0;


        for (int i = 0; i < heights.Length; i++){
            Console.Write("Enter height of player {0}: ", i + 1);
            heights[i] = double.Parse(Console.ReadLine()); // reading the input from user
            sum += heights[i]; // adding heights and storing it in sum
        }

        // calculating mean height
        double meanHeight = sum / heights.Length;

        // displaying the mean height of the football team
        Console.WriteLine("The mean height of the football team is: {0} meters", meanHeight);
    }
}
