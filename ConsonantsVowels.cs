using System;

public class ConsonantsVowels{

	public static void Main(){
		Console.Write("enter the string: ");
		string word = Console.ReadLine();
		// converting the string to lowercase so that we can apply our method
		word = word.ToLower();
		checkConsonantsVowels(word);
	}

	public static void checkConsonantsVowels(string word){
		// this method has a limitation that is counts spaces as consonants too
		int vowels = 0, consonants = 0;
		// using foreach loop to iterate over the string
		foreach( char ch in word){
			// using equality operator to compare joined them using or operator
			if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'){
				vowels++;
			}
			else{
				consonants++;
			}
		}
		Console.WriteLine("the word has {0} vowels and {1} consonants", vowels, consonants);
	}

}