using System;

class ReverseString{
	public static string ReversingWord(string str){
		// using a new string to store the reversed string
		string revString = "";
		for(int i = str.Length - 1; i >= 0; i--){
		// str[i] in C# is similar to str.chatAt(i) in java
			revString += str[i];
		}
		// we can also apply two pointer or stringbuilder to optimise the solution
		return revString;
	}
	
	public static void Main(){
		Console.Write("enter the string: ");
		string str = Console.ReadLine();
		// calling method to reverse the string
		string reverseString = ReversingWord(str);
		Console.WriteLine("the original string is {0}", str);
		Console.WriteLine("the reversed string is {0}", reverseString);
	}
}