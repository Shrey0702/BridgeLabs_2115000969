using System;

class BitwiseOperators {
	static void Main(string[] args) {
		int a = 21; 
		int b = 17; 

		Console.WriteLine("a & b " + (a & b)); 
		Console.WriteLine("a | b " + (a | b)); 
		Console.WriteLine("a ^ b " + (a ^ b)); 
		Console.WriteLine("~a " + (~a)); 
		Console.WriteLine("a << 1 " + (a << 1));
		Console.WriteLine("a >> 1 " + (a >> 1));
	}
}