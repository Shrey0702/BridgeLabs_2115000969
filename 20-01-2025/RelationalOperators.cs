using System;

class RelationalOperators {
	static void Main(string[] args) {
		int a = 12;
		int b = 5;
		int c = 12;

		Console.WriteLine("a == c " + (a == b)); 
		Console.WriteLine("a != c " + (a != b)); 
		Console.WriteLine("a > b " + (a > b));
		Console.WriteLine("a < b " + (a < b)); 
		Console.WriteLine("b >= c " + (a >= b)); 
		Console.WriteLine("a <= b " + (a <= b));
	}
}