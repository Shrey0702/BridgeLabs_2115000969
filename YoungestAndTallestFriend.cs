using System;

public class YoungestAndTallestFriend{
    
    public static int YoungestFriend(int[] ages){
        int youngestIndex = 0; // using this for comparision
		// running loop from i = 1 because we don't need to compare with the same value again
        for (int i = 1; i < ages.Length; i++){
            if (ages[i] < ages[youngestIndex]){ // change the index whenever we find younger
                youngestIndex = i;
            }
        }
        return youngestIndex;
    }

    
    public static int TallestFriend(double[] heights){
        int tallestIndex = 0; 
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > heights[tallestIndex]){
                tallestIndex = i;  // updating the value as above
            }
        }
        return tallestIndex;
    }

    
    public static void Main(){
        int[] ages = new int[3];
        double[] heights = new double[3];
		// using a seperate name array because it will help us to use a loop to print the youngest and tallest
        string[] names = { "amar", "akbar", "anthony" };

        // input for age and height
        for (int i = 0; i < 3; i++){
            Console.Write("enter the age of {0}: ", names[i]);
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter the height of {0} : ", names[i]);
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // calling method to find youngest
        int youngestIndex = YoungestFriend(ages);

		// calling method to find tallest
        int tallestIndex = TallestFriend(heights);

        // displaying the results
        Console.WriteLine("The youngest friend is {0} with age {1} years", names[youngestIndex], ages[youngestIndex]);
        Console.WriteLine("The tallest friend is {0} with height {1}", names[tallestIndex], heights[tallestIndex]);
    }
}
