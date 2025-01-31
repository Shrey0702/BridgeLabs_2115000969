using System;

class GuessingGame{
	static void Main(){
		// taking input from the user
		Console.WriteLine("Enter the number between 1 and 100");
		int number = Convert.ToInt32(Console.ReadLine());
		// generating random number for the first time
		Random ran = new Random();
		int guess = ran.Next(1, 101);
		int high = 101;// to keep finding the highest closest to that number
		int low = 0; // to keep finding the lowest closest to that number
		
		bool flag = true;//to check if correct and close the game
		// while loop to keep the game continuing while the gussed is correct
		while(flag){
			Console.Write("guessed number is :" + guess);
			Console.WriteLine("Enter the feedback: ");
			string feedback = Console.ReadLine();
			//checks if the feedback is high and also changes the closest high to the number
			if(feedback == "high"){
				int temp = guess;
				high = guess;
				guess = ran.Next(low, temp);
			}
			//checks if the feedback is low and also changes the closest low to the number
			else if (feedback == "low"){
				int temp = guess;
				low = guess;
				guess = ran.Next(temp, high);
			}
			// end the game if the guess was correct
			else if(feedback == "correct"){
				Console.WriteLine("Guessed correctly ending the game xoxo");
				flag = false;
			}
			
		}
	}
}
