using System;
class ToggleCase{
	public static string Toggle(string str){
		// since we cannot use toUpper or toLower so we can take help of ASCII values
		string afterToggle = "";
		foreach(char ch in str){
			// using explicit typecasting to convert the char to ASCII value 
			// ASCII value in the range of 65-90 are capital letters
			if((int)ch <= 90 && (int) ch >= 65){
				// now we are explicitly converting int to ch and storing in our array
				// after adding 32 we can access the small case letters using ASCII value
				afterToggle += (char)(ch + 32);
			}
			// similar to above but here we just subtract the value by 32 to access the upper case letters
			else if((int) ch >= 97 && (int) ch <= 122){
				afterToggle += (char) (ch - 32);
			}
			// below case will run for all the other cases
			else{
				afterToggle += ch;
			}
		}
		return afterToggle;
	}
	
	public static void Main(){
		Console.Write("enter the string: ");
		string str = Console.ReadLine();
		string toggledString = Toggle(str);
		Console.WriteLine("original string: {0}", str);
		Console.WriteLine("string after toggling: {0}", toggledString);
	}
}