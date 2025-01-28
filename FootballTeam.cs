using System;

class FootballTeam{
    public static void Main(){
		// generating random heights
        int[] heights = GenerateRandomHeights(11); // 11 players in the football team

        // calculating sum, mean, shortest, and tallest heights
        int sum = Sum(heights);
        double mean = Mean(sum, heights.Length);
        int shortest = Shortest(heights);
        int tallest = Tallest(heights);

        // displaying the results
        foreach (int height in heights){
            Console.WriteLine(height);
        }

        Console.WriteLine("shortest height: " + shortest + " cm");
        Console.WriteLine("tallest height: " + tallest + " cm");
        Console.WriteLine("mean height: " + mean + " cm");
    }

    // method to generate an array of random heights for the players
    public static int[] GenerateRandomHeights(int size){
        Random rand = new Random();
        int[] heights = new int[size];

        // Generate random heights between 150 cm and 250 cm
        for (int i = 0; i < size; i++){
            heights[i] = rand.Next(150, 251); // Height between 150 and 250
        }

        return heights;
    }

    // method to find the sum 
    public static int Sum(int[] heights){
        int sum = 0;

        foreach (int height in heights){
            sum += height;
        }

        return sum;
    }

    public static double Mean(int sum, int numberOfPlayers){
        return (double)sum / numberOfPlayers; 
    }

    // method to find the shortest height
    public static int Shortest(int[] heights){
        int shortest = heights[0];

        foreach (int height in heights){
            if (height < shortest){
                shortest = height;
            }
        }

        return shortest;
    }

    // method to find the tallest height
    public static int Tallest(int[] heights){
        int tallest = heights[0];

        foreach (int height in heights){
            if (height > tallest){
                tallest = height;
            }
        }

        return tallest;
    }
}
