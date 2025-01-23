using System;


class RocketLaunchCountDown{
	static void CountdownBegins(int timer){
	int stop = 0;  // we assign value 0 because if we used 1 then it will just run until 1 and will not print 
	while(timer != stop){  // will run until timer will not be equal to 1
		Console.WriteLine(timer); // displayed the timer
		timer--; // decremented the value
	}
}
	
	public static void Main(){
		Console.Write("Enter the countdown duration: ");
		int timer = int.Parse(Console.ReadLine());
		CountdownBegins(timer);
	}
}


	
