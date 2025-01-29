using System;

class MostFrequentCharachter{
	public static char Mostfrequent (string str){
		// allocating spaces for all alphabets
		int[] alphaArray = new int[26];
	
		foreach(char ch in str){
		// converting ASCII to be able to fit in out 32 size array
			alphaArray[ch - 97] += 1;
		}
		int max = alphaArray[0];
		int maxIndex = 0;
		for(int i = 0; i < alphaArray.Length; i++){
			if(alphaArray[i] > max)	{
				max = alphaArray[i];
				maxIndex = i;
			}
		}
		
		return (char)(maxIndex + 97);
		
	}
	
	public static void Main(){
		Console.Write("String: ");
		string str = Console.ReadLine();
		char maxmOccurance = Mostfrequent(str);
		Console.WriteLine("Most Frequent Charachter: {0}", maxmOccurance);
	}
}