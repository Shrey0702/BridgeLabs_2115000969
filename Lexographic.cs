using System;

class Lexographic{

	public static void Main(){
		Console.WriteLine("String 1: ");
		string str1 = Console.ReadLine();
		Console.WriteLine("String 2: ");
		string str2 = Console.ReadLine();
		LexographicComparision(str1, str2);
	}
	public static void LexographicComparision(string str1, string str2){
		// comparing which is smaller in length
		string smaller = str1;
		string larger = str2;
		if(str1.Length > str2.Length){
			smaller = str2;
			larger = str1;
		}
		
		// using this flag value so that we can check if any of the condition is hit or not
		bool flag = true;
		// running a loop for te smaller string
		for(int i = 0; i < smaller.Length; i++){
			if(str1[i] == str2[i]){
				continue;
			}
			else if((int)str1[i] > (int)str2[i]){
				Console.WriteLine("string {0} comes before {1} in lexographic order", str2, str1);
				flag = false;
				break;
			}
			
			else if((int)str1[i] < (int)str2[i]){
				Console.WriteLine("string {0} comes before {1} in lexographic order", str1, str2);
				flag = false;
				break;
			}
		}
		if(flag){
				Console.WriteLine("string {0} comes before {1} in lexographic order", smaller, larger);
		}
	}
}