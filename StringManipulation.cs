class StringManipulation{
	public static void Main(){
		Console.Write("enter the string: ");
		string str = Console.ReadLine();
		ArrayList al = new ArrayList();
		al.add(0);
		for(int i = 1; i < str.Length; i++){
			if(str[i] == ' '){
					al.add(i - 1);
			}
		}
		for(int i = 0; i < al.Count/ 2; i++){
			char temp = str[i];
			str[i] = str[al.Count - 1];
			str[al.Count - 1] = temp;
		}
		Console.WriteLine(str);
		
	}
	

}
