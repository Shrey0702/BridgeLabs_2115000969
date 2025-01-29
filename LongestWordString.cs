using System;

class LongestWordString{
	public static string LongestWord(string sentence){
		// firstly we are counting the words so that we can create an array of that particular size
		int wordsCount = 0;
		for(int i = 0; i < sentence.Length; i++){
			if(sentence[i] == ' '){
				wordsCount++;
			}
		}
		// difining (size + 1) because one ' '  seperates two words
		string[] strArr = new string[wordsCount + 1];
		// creating temp string variable so that we can ad words to our array
		string tempStr = "";
		int index = 0;
		for(int i = 0; i < sentence.Length; i++){
			if(sentence[i] == ' '){
				strArr[index] = tempStr;
				tempStr = " ";
				index++;
				continue;  // it will prevent us to execute the below code
			}
			// updating the tempStr until we get ' '
			tempStr += sentence[i];
		}
		
		// at last we added the last word to the array because it is unidentified by the for loop
		strArr[index] = tempStr;
		
		// initialising longest with first index and then use it for comparision
		string longestString = strArr[0];
		foreach(string s in strArr){
			if(s.Length > longestString.Length){
				longestString = s;
			}
		}
		return longestString;
	}
	
	public static void Main(){
		Console.Write("enter a sentence: ");
		string sentence = Console.ReadLine();
		string longest = LongestWord(sentence);
		Console.WriteLine("the longest word in the string is {0}", longest);
	}
}