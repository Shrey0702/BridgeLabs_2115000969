using System;

class RemovingSpecificCharachter{
	public static string RemoveCharachter(string str, char wordToRemove){
		string result = "";
		foreach(char ch in str){
			if(ch == wordToRemove){
				continue;
			}
			result += ch;
		}
		return result;
	}
	
	public static void Main(){
		Console.Write("String: ");
		string str = Console.ReadLine();
		Console.Write("Charachter to Remove: ");
		char wordToRemove = char.Parse(Console.ReadLine());
		string stringWithoutChar = RemoveCharachter(str, wordToRemove);
		Console.WriteLine("Modified String: {0}", stringWithoutChar);
	}
}