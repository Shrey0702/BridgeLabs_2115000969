using System;


class RocketLaunchCountDownForLoop{
	static void CountdownBegins(int timer){
		// using for loop
		for(int i = timer; i > 0; i--){
			Console.WriteLine(i);
		}
}
	
	public static void Main(){
		Console.Write("Enter the countdown duration: ");
		int timer = int.Parse(Console.ReadLine());
		CountdownBegins(timer);
	}
}


	
