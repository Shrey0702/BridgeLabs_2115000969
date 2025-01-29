using System;

class PalindroneString{
	public static bool CheckPalindrone(string str){
		// using a new string to store the reversed string
		string revString = "";
		for(int i = str.Length - 1; i >= 0; i--){
		// str[i] in C# is similar to str.chatAt(i) in java
			revString += str[i];
		}
		// comparing two strings using String.Equals which returns a boolean value
		return String.Equals(str, revString);
	}
	
	public static void Main(){
		Console.Write("enter the string: ");
		string str = Console.ReadLine();
		// calling method to check if the string is palindrone or not
		bool result = CheckPalindrone(str);
		if(result){
			Console.WriteLine("the given string is palindrone");
		}
		else{
			Console.WriteLine("the given string is not palindrone");
		}
		
	}
}