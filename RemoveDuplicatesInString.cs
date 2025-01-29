using System;

class RemoveDuplicatesInString{
	public static void RemoveDuplicates(string str){
		// in this approach we will check if the char value occured before or not
		// if we find it before the current index then we will break the loop
		string stringNoDuplicates = "";
		for(int i = 0; i < str.Length; i++){
		// creating j outside becasue we need to compare it with index after running inner for loop
			int j = 0;
			while(j < i){
				if(str[i] == str[j]){
				// if this condition will be true then we will not add the char to our result and move to next char
					break;
				}
				j++;
			}
			// this conditon shows that we haven't found same charachter so we can add the current charachter
			if(i == j){
				stringNoDuplicates += str[i];
			}
			
		}
		Console.WriteLine("the string {0} without repeating charachters is {1}", str, stringNoDuplicates);
	}
	
	public static void Main(){
		Console.Write("enter the string: ");
		string str = Console.ReadLine();
		RemoveDuplicates(str);
	}
}