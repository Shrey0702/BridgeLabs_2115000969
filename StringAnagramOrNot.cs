using System;

class StringAnagramOrNot{
	public static bool CheckAnagram (string str1, string str2){
		if(str1.Length != str2.Length){
			return false;
		}
		// allocating spaces for all alphabets
		int[] occurrenceArray1 = new int[26];
		int[] occurrenceArray2 = new int[26];
	
		foreach(char ch in str1){
		// converting ASCII to be able to fit in 32 size array
			occurrenceArray1[ch - 97] += 1;
		}
		
		foreach(char ch in str2){
		// converting ASCII to be able to fit in 32 size array
			occurrenceArray2[ch - 97] += 1;
		}
		
		for(int i = 0; i < 26; i++){
			if(occurrenceArray1[i] != occurrenceArray2[i]){
				return false;
			}
		}
		
		return true;
		
	}
	
	public static void Main(){
		Console.Write("String 1: ");
		string str1 = Console.ReadLine();
		Console.Write("String 2: ");
		string str2 = Console.ReadLine();
		bool anagramOrNot = CheckAnagram(str1, str2);
		if(anagramOrNot){
			Console.WriteLine("both the strings are anagram");
		}
		else{
			Console.WriteLine("both the strings are NOT anagram of eachother");
		}
	}
}

