using System;

class YoungestAndTallest{
    public static void Main(){
        // arrays to store ages and heights
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // taking user input for ages and heights
        for (int i = 0; i < 3; i++){
		// taking both ages and heights with a single loop
            Console.Write("Enter the age of {0}: ", friends[i]);
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of {0} in meters: ", friends[i]);
            heights[i] = double.Parse(Console.ReadLine());
        }

        // finding the youngest friend
        int youngestAge = ages[0]; // declaring first one as the youngest to start comparision
        string youngestFriend = friends[0];
        for (int i = 1; i < 3; i++){
			// updating youngest if we find someone younger
            if (ages[i] < youngestAge){
                youngestAge = ages[i];
                youngestFriend = friends[i];
            }
        }

        // finding the tallest friend
        double tallestHeight = heights[0];
        string tallestFriend = friends[0];
        for (int i = 1; i < 3; i++){
		// updating the heights is we find taller
            if (heights[i] > tallestHeight){
                tallestHeight = heights[i];
                tallestFriend = friends[i];
            }
        }

        // displaying the results using String.Format
        Console.WriteLine("Youngest Friend: {0}, Age: {1}", youngestFriend, youngestAge);
        Console.WriteLine("Tallest Friend: {0}, Height: {1} ", tallestFriend, tallestHeight);
    }
}
