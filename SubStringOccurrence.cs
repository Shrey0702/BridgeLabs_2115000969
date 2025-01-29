using System;

class SubStringOccurrence{
	public static int FindOccurrence(string sentence, string subString){
	// using sliding window to solve the problem
		int occurrenceCount = 0;
		int slideLength = subString.Length;
		for(int i = 0; i < sentence.Length - slideLength + 1; i++){
			string tempString = "";
			// we are adding all the characters in the given range to the tempString
			for(int j = 0; j < slideLength; j++){
				tempString += sentence[i + j];
			}
			
			// we can also use for loop for comparing both strings
			if(string.Equals(tempString, subString)){
				// after comparing if it returns true then increment the occurrence value
				occurrenceCount++;
			}
		}
		return occurrenceCount;
	}
	
	public static void Main(){
		Console.Write("enter the sentence: ");
		string sentence = Console.ReadLine();
		Console.Write("enter the substring: ");
		string subString = Console.ReadLine();
		int occurrence = FindOccurrence(sentence, subString);
		Console.Write(occurrence);
	}
}


